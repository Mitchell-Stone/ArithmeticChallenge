using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ArithmeticChallengeStudent
{
    public partial class Student : Form
    {
        private static Socket clientSocket;
        private byte[] buffer;
        private int PORT = 3333;

        static EquationProperties equation;

        public Student()
        {
            InitializeComponent();
            btn_submit.Enabled = false;
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //connect to the specified host.
                var endPoint = new IPEndPoint(IPAddress.Parse("192.168.1.4"), PORT);
                clientSocket.BeginConnect(endPoint, ConnectCallback, null);
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
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                string message = Encoding.ASCII.GetString(buffer);
                int index = message.IndexOf("\0");
                message = message.Substring(0, index);
                
                if (message == "Connected to Server")
                {
                    Console.WriteLine(message);
                }
                else if (DeserializeJson(message) != null) 
                {
                    Console.WriteLine(message);
                    equation = DeserializeJson(message);

                    Invoke((Action)delegate
                    {
                        tb_question.Text = equation.FirstNumber.ToString() + equation.Symbol + equation.SecondNumber.ToString() + "=";
                        btn_submit.Enabled = true;
                    });
                }

                // Start receiving data again.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
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

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
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

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndSend(AR);
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

        private EquationProperties DeserializeJson(string json)
        {
            try
            {
                EquationProperties eq = JsonConvert.DeserializeObject<EquationProperties>(json);
                return eq;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (tb_answer.Text == equation.Result.ToString())
            {
                equation.IsCorrect = true;
                string json = JsonConvert.SerializeObject(equation);
                SendMessage(json);
            }
            else
            {
                equation.IsCorrect = false;
                string json = JsonConvert.SerializeObject(equation);
                SendMessage(json);
            }
            btn_submit.Enabled = false;
        }

        private void SendMessage(string json)
        {
            var sendData = Encoding.ASCII.GetBytes(json);
            clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallback, null);
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
