﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Welcometomymine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class ConnectionHandler
    {
        public string[] ip = System.IO.File.ReadLines(System.IO.Directory.GetCurrentDirectory() + @"\ip.txt").ToArray();
        


        Socket serverS = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static IPEndPoint GetLocalEndPoint()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 23);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                IPAddress ip = endPoint.Address;
                IPEndPoint Host = new IPEndPoint(ip, 23);
                socket.Close();

                
                return Host;
            }
           

        }

        static void Main()
        {
            
            ConnectionHandler Connection = new ConnectionHandler();
            Connection.serverS.Bind(GetLocalEndPoint());
            Connection.serverS.Listen(5);
            Socket conn = Connection.serverS.Accept();
            Connection.HandleConnection();



        }
        void HandleConnection()
        {
            
        }

    }
}