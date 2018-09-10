using ArithmeticChallenge.Controllers;
using ArithmeticChallenge.NodeFunctions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticChallenge
{
    public partial class Instructor : Form
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 333;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        //list of all current equations
        List<EquationProperties> equations = new List<EquationProperties>();

        EquationNodeList equationNodeList = new EquationNodeList();

        //symbols used in the dropdown to select for calculationss
        string[] operators = { "+", "-", "x", "/" };

        public Instructor()
        {
            InitializeComponent();
            dd_operator.DataSource = operators;

            LoadQuestionsDataGridView();

            SetupServer();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Server setup complete");
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("Client connected... Waiting to send message");
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //btn_send.Enabled = false;
            EquationProperties equation = new EquationProperties(Convert.ToUInt16(tb_firstNumber.Text),
                Convert.ToUInt16(tb_secondNumber.Text), dd_operator.Text, Convert.ToUInt16(tb_answer.Text), false);

            foreach (var socket in clientSockets)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(equation));
                socket.Send(buffer, 0 ,buffer.Length, SocketFlags.None);
            }
            
            //add to list to be displayed
            equations.Add(equation);

            //create new node and add to nodelist
            EquationNode node = new EquationNode(equation);
            equationNodeList.AddEquationNode(node);

            StringBuilder sb = new StringBuilder();
            if (rtb_linkList.Text == "")
            {
                sb.Append("Head <-> ");
                sb.Append(equationNodeList.getCurrentNode().NodeToString());
            }
            else
            {
                sb.Append(rtb_linkList.Text);
                sb.Append(" <-> ");
                sb.Append(equationNodeList.getCurrentNode().NodeToString());
            }

            rtb_linkList.Text = sb.ToString();

            RefreshResultDatagrid();
        }

        //loads the data grid view and allocates the data source values to the correct columns
        public void LoadQuestionsDataGridView()
        {
            dgv_questionsAsked.AutoGenerateColumns = false;
            dgv_questionsAsked.DataSource = equations;

            DataGridViewTextBoxColumn columnFirst = new DataGridViewTextBoxColumn();
            columnFirst.DataPropertyName = "FirstNumber";
            columnFirst.Name = "First";
            dgv_questionsAsked.Columns.Add(columnFirst);

            DataGridViewTextBoxColumn columnOperator = new DataGridViewTextBoxColumn();
            columnOperator.DataPropertyName = "Symbol";
            columnOperator.Name = "Operator";
            dgv_questionsAsked.Columns.Add(columnOperator);

            DataGridViewTextBoxColumn columnSecond = new DataGridViewTextBoxColumn();
            columnSecond.DataPropertyName = "SecondNumber";
            columnSecond.Name = "Second";
            dgv_questionsAsked.Columns.Add(columnSecond);

            DataGridViewTextBoxColumn columnResult = new DataGridViewTextBoxColumn();
            columnResult.DataPropertyName = "Result";
            columnResult.Name = "Result";
            dgv_questionsAsked.Columns.Add(columnResult);
        }

        //refreshes the data grid when a new object is added to the data source
        private void RefreshResultDatagrid()
        {
            dgv_questionsAsked.DataSource = null;

            dgv_questionsAsked.DataSource = equations;
        }

        #region Update result text box when calculation is changed
        private void dd_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }

        private void tb_firstNumber_TextChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }

        private void tb_secondNumber_TextChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }
        #endregion

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateControlStates(bool toggle)
        {
            Invoke((Action)delegate
            {
                btn_send.Enabled = toggle;
            });
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
