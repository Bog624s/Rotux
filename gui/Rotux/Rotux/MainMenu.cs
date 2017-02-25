using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
            if (!File.Exists(s.data["Flash Player"]))
            {
                playgamebtn.Text = "Download Projector";
            }
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
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            new Thread(StartThread).Start();
        }

        private void StartThread()
        {
            BeginInvoke(new Action(() => global.Value = 0));
            mysqlstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 35));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 45));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 55));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 65));
            Thread.Sleep(1000);
            wserverstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 75));
            serverstartbtn_Click(this, null);
            BeginInvoke(new Action(() => global.Value = 85));
            Thread.Sleep(1000);
            BeginInvoke(new Action(() => global.Value = 100));
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            global.Value = 0;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            serverstopbtn_Click(sender, e);
            global.Value = 33;
            wserverstopbtn_Click(sender, e);
            global.Value = 66;
            mysqlstopbtn_Click(sender, e);
            global.Value = 100;
            KillProcess("wServer.exe");
            KillProcess("server.exe");
            KillProcess("mysqld.exe");
            KillProcess("cmd.exe");
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

        private void playgamebtn_Click(object sender, EventArgs e)
        {
            new Thread(clientplay).Start();
        }

        void clientplay()
        {
            if (!File.Exists(s.data["Flash Player"]))
            {
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += (s, e) =>
                    {
                        BeginInvoke(new Action(() => global.Value = e.ProgressPercentage / 2));
                    };
                    client.DownloadFileCompleted += (s, e) =>
                    {
                        BeginInvoke(new Action(() => global.Value = 100));
                        BeginInvoke(new Action(() => playgamebtn.Text = "Start Client"));
                    };
                    client.DownloadFileAsync(new Uri(s.data["Flash Download"]), s.data["Flash Player"]);
                }
            } else
            {
                Process.Start(s.data["Flash Player"], s.data["Client"]);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            KillProcess("cmd.exe");
        }

        void KillProcess(string process)
        {
            global.Value = 0; int i = 0;
            var y = Process.GetProcessesByName(process);
            foreach (Process x in y)
            {
                global.Value = i / y.Length;
            }
            global.Value = 100;
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
