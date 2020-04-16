using EarlPeterG.IO;
using EarlPeterG.Win;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Windows.Forms;

namespace ImageCompressor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 2 && args[0] == "-uninstall") {
                RunUninstaller();
                return;
            }

            // Fix DPI issues with scaling for Windows 8 and higher
            if (Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App myApp = new App();
            myApp.Run(args);


            void RunUninstaller()
            {
                if (MessageBox.Show("Are you sure you want to uninstall " + Application.ProductName + "?", "Uninstall",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                    return;
                }

                // remove traces from PC
                var appDataPath = GetAppDataPath();
                if (Directory.Exists(appDataPath)) { Directory.Delete(appDataPath, true); }
                var appDataPathParent = Path.GetDirectoryName(appDataPath);
                if (FileHelper.DirectoryEmpty(appDataPathParent)) { Directory.Delete(appDataPathParent); }

                // run uninstaller
                ProcessHelper.RunProcessAsync(Path.Combine(Environment.SystemDirectory, "msiexec.exe"), "/x " + args[1] + " /passive");
            }
        }

        public static string GetAppDataPath() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EarlPeter\\ICP");


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }

    /// <summary>
    /// We inherit from the VB.NET WindowsFormApplicationBase class, which has the 
    /// single-instance functionality.
    /// </summary>
    internal class App : WindowsFormsApplicationBase
    {
        public App()
        {
            // Make this a single-instance application
            IsSingleInstance = true;
            EnableVisualStyles = true;

            // There are some other things available in the VB application model, for
            // instance the shutdown style:
            ShutdownStyle = ShutdownMode.AfterMainFormCloses;

            // Add StartupNextInstance handler
            StartupNextInstance += new StartupNextInstanceEventHandler(SIApp_StartupNextInstance);
        }

        /// <summary>
        /// We are responsible for creating the application's main form in this override.
        /// </summary>
        protected override void OnCreateMainForm()
        {
            // Create an instance of the main form and set it in the application; 
            // but don't try to run it.
            MainForm = new Form1();

            // We want to pass along the command-line arguments to this first instance

            // Allocate room in our string array
            ((Form1)MainForm).Args = new string[CommandLineArgs.Count];

            // And copy the arguments over to our form
            CommandLineArgs.CopyTo(((Form1)MainForm).Args, 0);
        }

        /// <summary>
        /// This is called for additional instances. The application model will call this 
        /// function, and terminate the additional instance when this returns.
        /// </summary>
        /// <param name="eventArgs"></param>
        protected void SIApp_StartupNextInstance(object sender, StartupNextInstanceEventArgs eventArgs)
        {
            // Copy the arguments to a string array
            string[] args = new string[eventArgs.CommandLine.Count];
            eventArgs.CommandLine.CopyTo(args, 0);

            // Create an argument array for the Invoke method
            object[] parameters = new object[2];
            parameters[0] = this.MainForm;
            parameters[1] = args;

            // Need to use invoke to b/c this is being called from another thread.
            MainForm.Invoke(new Form1.ProcessParametersDelegate(
                ((Form1)MainForm).ProcessParameters),
                parameters);
        }
    }
}
