using ArithmeticChallenge.Controllers;
using ArithmeticChallenge.NodeFunctions;
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
        //list of all current equations
        List<EquationProperties> equations = new List<EquationProperties>();

        EquationNodeList equationNodeList = new EquationNodeList();

        //symbols used in the dropdown to select for calculationss
        string[] operators = { "+", "-", "x", "/" };

        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;

        public Instructor()
        {
            InitializeComponent();
            dd_operator.DataSource = operators;

            LoadQuestionsDataGridView();

            StartServer();
        }

        private void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, 3333)); // bind on port  3333
                serverSocket.Listen(10); // listening on a backlog of ten pending connections
                serverSocket.BeginAccept(AcceptCallback, null); // start accepting incoming 
                Console.WriteLine("Server Started");
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            btn_send.Enabled = false;
            EquationProperties equation = new EquationProperties(Convert.ToUInt16(tb_firstNumber.Text),
                Convert.ToUInt16(tb_secondNumber.Text), dd_operator.Text, Convert.ToUInt16(tb_answer.Text), false);

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

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                serverSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = serverSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                string message = Encoding.ASCII.GetString(buffer);

                Invoke((Action)delegate
                {
                    Text = "Server says: " + message;
                });

                // Start receiving data again.
                serverSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            // Avoid catching all exceptions handling in cases like these.
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket = serverSocket.EndAccept(AR); // set up the clientsocket
                buffer = new byte[clientSocket.ReceiveBufferSize]; // intialise the buffer to proper buffer size

                // Send a message to the newly connected client.
                var sendData = Encoding.ASCII.GetBytes("Hello");
                clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallback, null);
                // Listen for client data.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
                // Continue listening for clients.
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
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
    }
}
