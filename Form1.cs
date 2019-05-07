using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp_test_client
{
    public partial class Form1 : Form
    {
        static Socket socket;
        static byte[] buffer;
        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            buffer = new byte[100000];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            try
            {
            socket.Connect("127.0.0.1",2004);
                label_info.Text += "Connected";
            }
            catch (Exception ex)
            {
                label_info.Text += ex.Message;                
            }


        }

        private void TextBox_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                buffer = Encoding.ASCII.GetBytes(textBox_message.Text);
                socket.Send(buffer);
                textBox_message.Clear();
            }
        }
    }
}
