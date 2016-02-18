using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace cs327project
{
    public partial class server : Form
    {

     
      static int port = 11000;
    //  private static IPAddress localAddr = IPAddress.Parse("127.0.0.1");
      static TcpListener svr = new TcpListener(port);
     // TcpClient client = null;
     
     

        public server()
        {
            InitializeComponent();
            svr.Start();
        }

        

        private void start_Click(object sender, EventArgs e)
        {
            //feedback.Text = "Waiting for a connection...";
            // Start listening for client requests.
            //svr.Start();
            //while (exitButton.Enabled==true)
            //{

                TcpClient clt = svr.AcceptTcpClient();
                feedback.Enabled = true;
                feedback.Text = "Connected!";

                Byte[] bytes = new Byte[256];
                String data = null;

                int i;
                NetworkStream stream = clt.GetStream();
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    string temp = "received:" + data;
                    clientText.Text = temp;
                    //clientText.Enabled = !clientText.Enabled;

                    //// Process the data sent by the client.
                    //data = data.ToUpper();
                    //byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                }
                clt.Close();
            //}
            
            //svr.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.Enabled = false;
        }

        //private void send_Click(object sender, EventArgs e)
        //{
        //    // Loop to receive all the data sent by the client.
        //    int i;
        //    NetworkStream stream = client.GetStream();
        //    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
        //    {
        //        // Translate data bytes to a ASCII string.
        //        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
        //        clientText.Text = "Received:" + data;

        //        // Process the data sent by the client.
        //        data = data.ToUpper();
        //        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

        //        // Send back a response.
        //        stream.Write(msg, 0, msg.Length);
        //        serverText.Text = "Sent: {0}" + data;
        //    }
        //    client.Close();
        //    }
        }
    }