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
        private static readonly Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 333;

        static EquationProperties equation;

        static string question = null;

        public Student()
        {
            InitializeComponent();
            ConnectToServer();            
        }

        private static void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    Console.WriteLine("Connection attempt " + attempts);
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex);
                }
            }
            Console.WriteLine("Connected");
        }
        
        private static void ReceiveResponse()
        {
            try
            {
                var buffer = new byte[150];
                int received = ClientSocket.Receive(buffer, SocketFlags.None);
                if (received != 0)
                {
                    string text = Encoding.ASCII.GetString(buffer);
                    int index = text.IndexOf("\0");
                    text = text.Remove(index, text.Length - index);

                    equation = JsonConvert.DeserializeObject<EquationProperties>(text);

                    question = equation.FirstNumber + equation.Symbol + equation.SecondNumber + "=";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);            
            }         
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (tb_answer.Text == equation.Result.ToString())
            {
                equation.IsCorrect = true;
                string json = JsonConvert.SerializeObject(equation);
                SendString(json);
            }
            else
            {
                equation.IsCorrect = false;
                string json = JsonConvert.SerializeObject(equation);
                SendString(json);
            }
            
        }

        private static void SendString(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Exit();
            this.Close();
        }

        private static void Exit()
        {
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }

        private void tb_connect_Click(object sender, EventArgs e)
        {
            ReceiveResponse();
        }
    }
}
