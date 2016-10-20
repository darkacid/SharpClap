using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SharpClap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task mytask = Task.Run(() =>
            //Thread myThread = new System.Threading.Thread(delegate () 
            //Your code here

            {
                // Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                const int PORT_NO = 4242;
                const string SERVER_IP = "127.0.0.1";

                //---listen at the specified IP and port no.---
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                Console.WriteLine("Listening...");
                listener.Start();

                //---incoming client connected---
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client Connected!");
                

            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSharpClap(mytask));
        }
    }
}
