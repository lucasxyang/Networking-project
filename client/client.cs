using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace client
{
    public partial class client : Form
    {
        static int port = 11000;
        TcpClient client1 = null;
        public client()
        {
            InitializeComponent();

        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                client1 = new TcpClient("localhost", port);
                status.Text = "connected";
            }
            catch{
                status.Text = "Failed"; return;
            }
        }


        private void clientSd_Click(object sender, EventArgs e)
        {
            string msg = clientBox.Text;
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            // Get a client stream for reading and writing.
            //  Stream stream = client.GetStream();

            NetworkStream stream = client1.GetStream();

            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);
            stream.Close();
        }

    }
}
