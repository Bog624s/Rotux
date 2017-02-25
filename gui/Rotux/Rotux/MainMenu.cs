using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Rotux
{
    public partial class MainMenu : Form
    {
        ProcessHandler wServer, Server, MySQL;
        string wServerLoc, ServerLoc, MySQLStartLoc, MySQLStopLoc;
        Settings s;

        public MainMenu(Settings s)
        {
            this.s = s;
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Text = s.data["Title"];
            if (s.data["Background"] != "null")
                BackgroundImage = Image.FromFile(s.data["Background"]);

            if (s.data["Header"] != "null")
                Header.Image = Image.FromFile(s.data["Header"]);

            Directory.SetCurrentDirectory(@"..\..\..\..\..");

            wServerLoc = s.data["World Server"];
            ServerLoc = s.data["Request Server"];
            MySQLStartLoc = s.data["MySQL Start"];
            MySQLStopLoc = s.data["MySQL Stop"];

            wServer = new ProcessHandler(wServerOutput, wServerLoc, this);
            Server = new ProcessHandler(ServerOutput, ServerLoc, this);
            MySQL = new ProcessHandler(MySQLOutput, MySQLStartLoc, this);
        }
        private void serverstartbtn_Click(object sender, EventArgs e)
        {
            Server.Start();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            new Thread(StartThread).Start();
        }

        private void StartThread()
        {
            mysqlstartbtn_Click(this, null);
            Thread.Sleep(5000);
            wserverstartbtn_Click(this, null);
            serverstartbtn_Click(this, null);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            serverstopbtn_Click(sender, e);
            wserverstopbtn_Click(sender, e);
            mysqlstopbtn_Click(sender, e);
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            s.Edit();
        }

        private void loadsettingsbtn_Click(object sender, EventArgs e)
        {
            s.Load();
            LoadSettings();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopbtn_Click(sender,e);
        }

        private void wserverstartbtn_Click(object sender, EventArgs e)
        {
            wServer.Start();
        }

        private void mysqlstartbtn_Click(object sender, EventArgs e)
        {
            MySQL.Start();
        }

        private void wserverstopbtn_Click(object sender, EventArgs e)
        {
            wServer.Stop();
            wServer.Dispose();
            wServer = new ProcessHandler(wServerOutput, wServerLoc, this);
            wServerOutput.Clear();
        }

        private void serverstopbtn_Click(object sender, EventArgs e)
        {
            Server.Stop();
            Server.Dispose();
            Server = new ProcessHandler(ServerOutput, ServerLoc, this);
            ServerOutput.Clear();
        }

        private void mysqlstopbtn_Click(object sender, EventArgs e)
        {
            MySQL.Stop();
            MySQL.Dispose();
            MySQL = new ProcessHandler(MySQLOutput, MySQLStopLoc, this);
            MySQL.Start();
            MySQL.Wait();
            MySQL.Dispose();
            MySQL = new ProcessHandler(MySQLOutput, MySQLStartLoc, this);
            MySQLOutput.Clear();
        }
    }
}
