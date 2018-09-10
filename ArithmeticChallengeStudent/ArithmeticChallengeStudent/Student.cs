using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ArithmeticChallengeStudent
{
    public partial class Student : Form
    {
        private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 333;

        public Student()
        {
            InitializeComponent();
            ConnectToServer();
            ReceiveResponse();
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
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
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
                var buffer = new byte[11];
                int received = ClientSocket.Receive(buffer, SocketFlags.None);
                if (received == 0) return;
                var data = new byte[received];
                var question = new EquationProperties(buffer);
                Array.Copy(buffer, data, received);
                string text = Encoding.ASCII.GetString(data);
                Console.WriteLine(question.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }         
        }

        private static void SendRequest()
        {
           
        }

        private static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //SendString(tb_answer.Text);
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

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
