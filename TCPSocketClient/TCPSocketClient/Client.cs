/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing;
//
// Client.cs
//
using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
 

namespace TCPSocketClient
{
	/// <summary>
	/// Description of Client.
	/// </summary>
	public partial class Client : Form
	{
		        private StreamReader clientStreamReader;
        private StreamWriter clientStreamWriter;
		public Client()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private bool ConnectToServer()
        {
            //connect to server at given port
            try
            {
                TcpClient tcpClient = new TcpClient("localhost",4444); 
                Console.WriteLine("Connected to Server");
                //get a network stream from server
                NetworkStream clientSockStream = tcpClient.GetStream();
                clientStreamReader = new StreamReader(clientSockStream);
                clientStreamWriter = new StreamWriter(clientSockStream);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
 
            return true;
        }
		
		void BtnConnectToServerClick(object sender, EventArgs e)
		{
			//connect to server
            if (!ConnectToServer())
            	textBox1.Text = "Unable to connect to server";
                //Console.WriteLine("Unable to connect to server");
		}
		void BtnSendMessageClick(object sender, EventArgs e)
		{
			try
            {
                //send message to server
                //clientStreamWriter.WriteLine("Hello!");
                clientStreamWriter.WriteLine(textBox1.Text);
                clientStreamWriter.Flush();
                richTextBox1.Text = "SERVER: "+clientStreamReader.ReadLine() + "\n" + richTextBox1.Text;
                //Console.WriteLine("SERVER: "+clientStreamReader.ReadLine());
            }
            catch(Exception se)
            {
                Console.WriteLine(se.StackTrace);
                richTextBox1.Text = richTextBox1.Text + "\n" + se.StackTrace;
            }
		}
	}
}
