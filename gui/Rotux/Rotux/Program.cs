using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Rotux
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!(args.Length == 1 && args[0] == "debug"))
                AppDomain.CurrentDomain.UnhandledException += ExceptionHandler;
            string setting = "config.cfg";
            bool excmode = false;
            if (args.Length == 2)
            {
                if (args[0] == "exception")
                    excmode = true;
            }
            if (excmode)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ExceptionWindow(Base64Decode(args[1])));
            }
            else
            {
                foreach (string s in args)
                {
                    if (File.Exists(s))
                        setting = s;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainMenu(new Settings(setting)));

            }
        }
        static void ExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            string msg = ((Exception)args.ExceptionObject).ToString();
            Process.Start(Assembly.GetExecutingAssembly().Location, "exception " + Base64Encode(msg));
            Environment.Exit(0);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
