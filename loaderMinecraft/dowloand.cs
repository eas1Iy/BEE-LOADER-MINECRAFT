using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaderMinecraft
{
    public partial class dowloand : Form
    {
        public dowloand()
        {
            InitializeComponent();
        }

        async void dowloand_Load(object sender, EventArgs e)
        {
            DownloadAll();
            //for (int i = 0; i < 101; i++)
            //{
            //    guna2ProgressBar1.Increment(1);
            //    await Task.Delay(50);
            //}
        }

        public void DownloadAll()
        {
            string host = @"s24.joinserver.ru";
            string username = "y5bq0wrk.b11838bf".ToString();
            string password = "brN-eNb-eKq-B7y".ToString();

            string remoteDirectory = "/mods/";
            string localDirectory = @"C:\Users\eas1ly\Desktop\modz";

            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();
                var files = sftp.ListDirectory(remoteDirectory);

                foreach (var file in files)
                {
                    string remoteFileName = file.Name;
                    if ((!file.Name.StartsWith(".")) && ((file.LastWriteTime.Date == DateTime.Today)))
                    using (Stream file1 = File.OpenWrite(localDirectory + remoteFileName))
                        {
                            sftp.DownloadFile(remoteDirectory + remoteFileName, file1);
                        }
                }

            }
        }

        public void DownloadFile()
        {
            string host = @"s24.joinserver.ru";
            string username = "y5bq0wrk.b11838bf";
            string password = "nSk-Tpe-KfR-6Xc";
            string localFileName = System.IO.Path.GetFileName(@"mods/rftools-1.12-7.73.jar");
            string remoteDirectory = "/export/";
            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();
                var files = sftp.ListDirectory(remoteDirectory);
                foreach (var file in files)
                {
                    if (!file.Name.StartsWith("."))
                    {
                        string remoteFileName = file.Name;
                        if (file.LastWriteTime.Date == DateTime.Today)

                            Console.WriteLine(file.FullName);

                        File.OpenWrite(localFileName);

                        string sDir = @"localpath";

                        Stream file1 = File.OpenRead(remoteDirectory + file.Name);
                        sftp.DownloadFile(remoteDirectory, file1);
                    }
                }
            }
        }
    }
}
