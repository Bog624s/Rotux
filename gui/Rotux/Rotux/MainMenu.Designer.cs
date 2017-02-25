namespace Rotux
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.wserverstartbtn = new System.Windows.Forms.Button();
            this.serverstartbtn = new System.Windows.Forms.Button();
            this.mysqlstartbtn = new System.Windows.Forms.Button();
            this.wserverstopbtn = new System.Windows.Forms.Button();
            this.serverstopbtn = new System.Windows.Forms.Button();
            this.mysqlstopbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.ConsoleTabs = new System.Windows.Forms.TabControl();
            this.wServerConsole = new System.Windows.Forms.TabPage();
            this.wServerOutput = new System.Windows.Forms.TextBox();
            this.serverConsole = new System.Windows.Forms.TabPage();
            this.ServerOutput = new System.Windows.Forms.TextBox();
            this.MySQLConsole = new System.Windows.Forms.TabPage();
            this.MySQLOutput = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.loadsettingsbtn = new System.Windows.Forms.Button();
            this.playgamebtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SimpleMenu = new System.Windows.Forms.TabPage();
            this.AdvancedMenu = new System.Windows.Forms.TabPage();
            this.dbcreatebtn = new System.Windows.Forms.Button();
            this.global = new System.Windows.Forms.ProgressBar();
            this.RealConsole = new System.Windows.Forms.TabPage();
            this.ConsoleOutput = new System.Windows.Forms.TextBox();
            this.ConsoleTabs.SuspendLayout();
            this.wServerConsole.SuspendLayout();
            this.serverConsole.SuspendLayout();
            this.MySQLConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SimpleMenu.SuspendLayout();
            this.AdvancedMenu.SuspendLayout();
            this.RealConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // wserverstartbtn
            // 
            this.wserverstartbtn.Location = new System.Drawing.Point(6, 6);
            this.wserverstartbtn.Name = "wserverstartbtn";
            this.wserverstartbtn.Size = new System.Drawing.Size(124, 23);
            this.wserverstartbtn.TabIndex = 2;
            this.wserverstartbtn.Text = "wServer Start";
            this.wserverstartbtn.UseVisualStyleBackColor = true;
            this.wserverstartbtn.Click += new System.EventHandler(this.wserverstartbtn_Click);
            // 
            // serverstartbtn
            // 
            this.serverstartbtn.Location = new System.Drawing.Point(6, 35);
            this.serverstartbtn.Name = "serverstartbtn";
            this.serverstartbtn.Size = new System.Drawing.Size(124, 23);
            this.serverstartbtn.TabIndex = 3;
            this.serverstartbtn.Text = "Server Start";
            this.serverstartbtn.UseVisualStyleBackColor = true;
            this.serverstartbtn.Click += new System.EventHandler(this.serverstartbtn_Click);
            // 
            // mysqlstartbtn
            // 
            this.mysqlstartbtn.Location = new System.Drawing.Point(6, 64);
            this.mysqlstartbtn.Name = "mysqlstartbtn";
            this.mysqlstartbtn.Size = new System.Drawing.Size(124, 23);
            this.mysqlstartbtn.TabIndex = 4;
            this.mysqlstartbtn.Text = "MySQL Start";
            this.mysqlstartbtn.UseVisualStyleBackColor = true;
            this.mysqlstartbtn.Click += new System.EventHandler(this.mysqlstartbtn_Click);
            // 
            // wserverstopbtn
            // 
            this.wserverstopbtn.Location = new System.Drawing.Point(164, 6);
            this.wserverstopbtn.Name = "wserverstopbtn";
            this.wserverstopbtn.Size = new System.Drawing.Size(124, 23);
            this.wserverstopbtn.TabIndex = 5;
            this.wserverstopbtn.Text = "wServer Stop";
            this.wserverstopbtn.UseVisualStyleBackColor = true;
            this.wserverstopbtn.Click += new System.EventHandler(this.wserverstopbtn_Click);
            // 
            // serverstopbtn
            // 
            this.serverstopbtn.Location = new System.Drawing.Point(164, 35);
            this.serverstopbtn.Name = "serverstopbtn";
            this.serverstopbtn.Size = new System.Drawing.Size(124, 23);
            this.serverstopbtn.TabIndex = 6;
            this.serverstopbtn.Text = "Server Stop";
            this.serverstopbtn.UseVisualStyleBackColor = true;
            this.serverstopbtn.Click += new System.EventHandler(this.serverstopbtn_Click);
            // 
            // mysqlstopbtn
            // 
            this.mysqlstopbtn.Location = new System.Drawing.Point(164, 64);
            this.mysqlstopbtn.Name = "mysqlstopbtn";
            this.mysqlstopbtn.Size = new System.Drawing.Size(124, 23);
            this.mysqlstopbtn.TabIndex = 7;
            this.mysqlstopbtn.Text = "MySQL Stop";
            this.mysqlstopbtn.UseVisualStyleBackColor = true;
            this.mysqlstopbtn.Click += new System.EventHandler(this.mysqlstopbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(6, 6);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(282, 62);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start Private Server";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Enabled = false;
            this.stopbtn.Location = new System.Drawing.Point(6, 74);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(282, 62);
            this.stopbtn.TabIndex = 1;
            this.stopbtn.Text = "Stop Private Server";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // ConsoleTabs
            // 
            this.ConsoleTabs.Controls.Add(this.wServerConsole);
            this.ConsoleTabs.Controls.Add(this.serverConsole);
            this.ConsoleTabs.Controls.Add(this.MySQLConsole);
            this.ConsoleTabs.Controls.Add(this.RealConsole);
            this.ConsoleTabs.Location = new System.Drawing.Point(323, 160);
            this.ConsoleTabs.Name = "ConsoleTabs";
            this.ConsoleTabs.SelectedIndex = 0;
            this.ConsoleTabs.Size = new System.Drawing.Size(289, 227);
            this.ConsoleTabs.TabIndex = 9;
            // 
            // wServerConsole
            // 
            this.wServerConsole.Controls.Add(this.wServerOutput);
            this.wServerConsole.Location = new System.Drawing.Point(4, 22);
            this.wServerConsole.Name = "wServerConsole";
            this.wServerConsole.Padding = new System.Windows.Forms.Padding(3);
            this.wServerConsole.Size = new System.Drawing.Size(281, 201);
            this.wServerConsole.TabIndex = 0;
            this.wServerConsole.Text = "wServer";
            this.wServerConsole.UseVisualStyleBackColor = true;
            // 
            // wServerOutput
            // 
            this.wServerOutput.Location = new System.Drawing.Point(6, 6);
            this.wServerOutput.Multiline = true;
            this.wServerOutput.Name = "wServerOutput";
            this.wServerOutput.ReadOnly = true;
            this.wServerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wServerOutput.Size = new System.Drawing.Size(269, 187);
            this.wServerOutput.TabIndex = 0;
            // 
            // serverConsole
            // 
            this.serverConsole.Controls.Add(this.ServerOutput);
            this.serverConsole.Location = new System.Drawing.Point(4, 22);
            this.serverConsole.Name = "serverConsole";
            this.serverConsole.Padding = new System.Windows.Forms.Padding(3);
            this.serverConsole.Size = new System.Drawing.Size(281, 201);
            this.serverConsole.TabIndex = 1;
            this.serverConsole.Text = "Server";
            this.serverConsole.UseVisualStyleBackColor = true;
            // 
            // ServerOutput
            // 
            this.ServerOutput.Location = new System.Drawing.Point(6, 6);
            this.ServerOutput.Multiline = true;
            this.ServerOutput.Name = "ServerOutput";
            this.ServerOutput.ReadOnly = true;
            this.ServerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ServerOutput.Size = new System.Drawing.Size(269, 187);
            this.ServerOutput.TabIndex = 1;
            // 
            // MySQLConsole
            // 
            this.MySQLConsole.Controls.Add(this.MySQLOutput);
            this.MySQLConsole.Location = new System.Drawing.Point(4, 22);
            this.MySQLConsole.Name = "MySQLConsole";
            this.MySQLConsole.Size = new System.Drawing.Size(281, 201);
            this.MySQLConsole.TabIndex = 2;
            this.MySQLConsole.Text = "MySQL";
            this.MySQLConsole.UseVisualStyleBackColor = true;
            // 
            // MySQLOutput
            // 
            this.MySQLOutput.Location = new System.Drawing.Point(6, 6);
            this.MySQLOutput.Multiline = true;
            this.MySQLOutput.Name = "MySQLOutput";
            this.MySQLOutput.ReadOnly = true;
            this.MySQLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MySQLOutput.Size = new System.Drawing.Size(269, 187);
            this.MySQLOutput.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackgroundImage = global::Rotux.Properties.Resources.sand;
            this.Header.Location = new System.Drawing.Point(15, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(593, 141);
            this.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Header.TabIndex = 10;
            this.Header.TabStop = false;
            // 
            // settingsbtn
            // 
            this.settingsbtn.Location = new System.Drawing.Point(6, 93);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(124, 23);
            this.settingsbtn.TabIndex = 11;
            this.settingsbtn.Text = "Edit Settings";
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // loadsettingsbtn
            // 
            this.loadsettingsbtn.Location = new System.Drawing.Point(164, 93);
            this.loadsettingsbtn.Name = "loadsettingsbtn";
            this.loadsettingsbtn.Size = new System.Drawing.Size(124, 23);
            this.loadsettingsbtn.TabIndex = 12;
            this.loadsettingsbtn.Text = "Load Settings";
            this.loadsettingsbtn.UseVisualStyleBackColor = true;
            this.loadsettingsbtn.Click += new System.EventHandler(this.loadsettingsbtn_Click);
            // 
            // playgamebtn
            // 
            this.playgamebtn.Location = new System.Drawing.Point(25, 343);
            this.playgamebtn.Name = "playgamebtn";
            this.playgamebtn.Size = new System.Drawing.Size(282, 40);
            this.playgamebtn.TabIndex = 13;
            this.playgamebtn.Text = "Start Client";
            this.playgamebtn.UseVisualStyleBackColor = true;
            this.playgamebtn.Click += new System.EventHandler(this.playgamebtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SimpleMenu);
            this.tabControl1.Controls.Add(this.AdvancedMenu);
            this.tabControl1.Location = new System.Drawing.Point(15, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 181);
            this.tabControl1.TabIndex = 14;
            // 
            // SimpleMenu
            // 
            this.SimpleMenu.Controls.Add(this.stopbtn);
            this.SimpleMenu.Controls.Add(this.startbtn);
            this.SimpleMenu.Location = new System.Drawing.Point(4, 22);
            this.SimpleMenu.Name = "SimpleMenu";
            this.SimpleMenu.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleMenu.Size = new System.Drawing.Size(294, 155);
            this.SimpleMenu.TabIndex = 0;
            this.SimpleMenu.Text = "Simple";
            this.SimpleMenu.UseVisualStyleBackColor = true;
            // 
            // AdvancedMenu
            // 
            this.AdvancedMenu.Controls.Add(this.dbcreatebtn);
            this.AdvancedMenu.Controls.Add(this.wserverstartbtn);
            this.AdvancedMenu.Controls.Add(this.wserverstopbtn);
            this.AdvancedMenu.Controls.Add(this.loadsettingsbtn);
            this.AdvancedMenu.Controls.Add(this.serverstartbtn);
            this.AdvancedMenu.Controls.Add(this.settingsbtn);
            this.AdvancedMenu.Controls.Add(this.serverstopbtn);
            this.AdvancedMenu.Controls.Add(this.mysqlstopbtn);
            this.AdvancedMenu.Controls.Add(this.mysqlstartbtn);
            this.AdvancedMenu.Location = new System.Drawing.Point(4, 22);
            this.AdvancedMenu.Name = "AdvancedMenu";
            this.AdvancedMenu.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedMenu.Size = new System.Drawing.Size(294, 155);
            this.AdvancedMenu.TabIndex = 1;
            this.AdvancedMenu.Text = "Advanced";
            this.AdvancedMenu.UseVisualStyleBackColor = true;
            // 
            // dbcreatebtn
            // 
            this.dbcreatebtn.Location = new System.Drawing.Point(6, 122);
            this.dbcreatebtn.Name = "dbcreatebtn";
            this.dbcreatebtn.Size = new System.Drawing.Size(124, 23);
            this.dbcreatebtn.TabIndex = 13;
            this.dbcreatebtn.Text = "Create Database";
            this.dbcreatebtn.UseVisualStyleBackColor = true;
            this.dbcreatebtn.Click += new System.EventHandler(this.dbcreatebtn_Click);
            // 
            // global
            // 
            this.global.Location = new System.Drawing.Point(15, 142);
            this.global.Name = "global";
            this.global.Size = new System.Drawing.Size(593, 13);
            this.global.TabIndex = 15;
            // 
            // RealConsole
            // 
            this.RealConsole.Controls.Add(this.ConsoleOutput);
            this.RealConsole.Location = new System.Drawing.Point(4, 22);
            this.RealConsole.Name = "RealConsole";
            this.RealConsole.Size = new System.Drawing.Size(281, 201);
            this.RealConsole.TabIndex = 3;
            this.RealConsole.Text = "Console";
            this.RealConsole.UseVisualStyleBackColor = true;
            // 
            // ConsoleOutput
            // 
            this.ConsoleOutput.Location = new System.Drawing.Point(6, 7);
            this.ConsoleOutput.Multiline = true;
            this.ConsoleOutput.Name = "ConsoleOutput";
            this.ConsoleOutput.ReadOnly = true;
            this.ConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleOutput.Size = new System.Drawing.Size(269, 187);
            this.ConsoleOutput.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 399);
            this.Controls.Add(this.global);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.playgamebtn);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ConsoleTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rotux Private Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ConsoleTabs.ResumeLayout(false);
            this.wServerConsole.ResumeLayout(false);
            this.wServerConsole.PerformLayout();
            this.serverConsole.ResumeLayout(false);
            this.serverConsole.PerformLayout();
            this.MySQLConsole.ResumeLayout(false);
            this.MySQLConsole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SimpleMenu.ResumeLayout(false);
            this.AdvancedMenu.ResumeLayout(false);
            this.RealConsole.ResumeLayout(false);
            this.RealConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wserverstartbtn;
        private System.Windows.Forms.Button serverstartbtn;
        private System.Windows.Forms.Button mysqlstartbtn;
        private System.Windows.Forms.Button wserverstopbtn;
        private System.Windows.Forms.Button serverstopbtn;
        private System.Windows.Forms.Button mysqlstopbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.TabControl ConsoleTabs;
        private System.Windows.Forms.TabPage wServerConsole;
        private System.Windows.Forms.TabPage serverConsole;
        private System.Windows.Forms.TabPage MySQLConsole;
        private System.Windows.Forms.TextBox wServerOutput;
        private System.Windows.Forms.TextBox ServerOutput;
        private System.Windows.Forms.TextBox MySQLOutput;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button loadsettingsbtn;
        private System.Windows.Forms.Button playgamebtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SimpleMenu;
        private System.Windows.Forms.TabPage AdvancedMenu;
        private System.Windows.Forms.ProgressBar global;
        private System.Windows.Forms.Button dbcreatebtn;
        private System.Windows.Forms.TabPage RealConsole;
        private System.Windows.Forms.TextBox ConsoleOutput;
    }
}

