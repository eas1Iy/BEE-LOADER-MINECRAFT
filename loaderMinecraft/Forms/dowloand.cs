using BEE.Properties;
using Guna.UI.Lib.ScrollBar;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
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

        string gamePath = Settings.Default["pathLauncher"].ToString();
        public string pathMod = "";

        public string hostName = "s24.joinserver.ru";
        public int port = 2022;
        public string username = "y5bq0wrk.b11838bf";
        public string password = "brN-eNb-eKq-B7y";

        List<string> serverMods;
        public bool fix;
        Thread ss;

        async void dowloand_Load(object sender, EventArgs e)
        {
            await Task.Run(() => show());
            await Task.Run(() => DownloadAll());
        }

        bool show()  // Загрузка списка обновленных модов
        {
            _anim.Show(_loadingMods);
            _anim.Show(_labelLoading);
            _anim.Show(gunaVSeparator1);
            _anim.Show(progress);

            using (var sftp = new SftpClient(hostName, port, username, password))
            {
                try
                {
                    Stream vers = File.OpenWrite(@"temp_mods.ini");
                    sftp.Connect();
                    sftp.DownloadFile(@"/LOADER/mods.txt", vers);
                    vers.Dispose();
                    string lastModsUpdate = File.ReadAllText(@"temp_mods.ini");
                    if (File.Exists(@"temp_mods.ini"))
                    {
                        updateDowloand.Text = lastModsUpdate;
                        _anim.Hide(_updateLoading);
                        _anim.Show(updateDowloand);
                    }
                    File.Delete(@"temp_mods.ini");
                    sftp.Disconnect();
                }
                catch { return false; }
            }
            _anim.Show(updateDowloand);
            return false;
        }

        public void DownloadAll() // скачивание
        {
            ss = new Thread(DownloadAll1);
            ss.Start();
        }


        public async void DownloadAll1() // способ №1 - ошибка с паролем.
        {
            string remoteDirectory = "/user_mods/";
            string remoteDirectoryConfig = "/user_configs/";
            string localDirectory = Convert.ToString(Settings.Default["pathMods"] + @"\");
            string localDirectoryConfig = localDirectory.Replace("mods", "config");

            //
            serverMods = new List<string>();
            try
            {
                //Моды с фтп
                using (var sftp = new SftpClient(hostName, port, username, password))
                {
                    sftp.Connect();
                    var files = sftp.ListDirectory(remoteDirectory);

                    foreach (var file in files)
                    {
                        string remoteFileName = file.Name;
                        serverMods.Add(remoteFileName);
                    }
                }
                // удаление лишнего
                List<string> filezs = Directory.GetFiles(localDirectory, "*.*", SearchOption.AllDirectories).ToList();
                foreach (string s in filezs)
                {
                    string s1 = s.Replace(localDirectory, "");
                    if (!serverMods.Contains(s1))
                    {
                        File.Delete(localDirectory + s1);
                    }
                }
                // скачивание нового
                using (var sftp = new SftpClient(hostName, port, username, password))
                {
                    sftp.Connect();

                    foreach (string s in serverMods)
                    {
                        List<string> s2 = filezs;
                        string[] a = s2.ToArray();
                        for (int i = 0; i < a.Length; i++)
                        {
                            a[i] = a[i].Replace(localDirectory, "");
                        }
                        if (!a.Contains(s))
                        {
                            using (Stream file1 = File.OpenWrite(localDirectory + s))
                            {
                                SftpFileAttributes attributes = sftp.GetAttributes(remoteDirectory + s);
                                progress.Invoke((MethodInvoker)delegate { progress.Maximum = (int)attributes.Size; });
                                sftp.DownloadFile(remoteDirectory + s, file1, DownloadProgresBar);
                            }
                        }
                    }
                    DownloadDirectory(sftp, remoteDirectoryConfig, localDirectoryConfig);
                }
                if (fix == false)
                {
                    startMinecraft();
                    // 
                    await Task.Delay(200);
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка загрузки.", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void DownloadProgresBar(ulong uploaded)
        {
            progress.Invoke((MethodInvoker)delegate { progress.Value = (int)uploaded; });
        }

        public static void DownloadDirectory(SftpClient sftpClient, string sourceRemotePath, string destLocalPath)
        {
            Directory.CreateDirectory(destLocalPath);
            IEnumerable<SftpFile> files = sftpClient.ListDirectory(sourceRemotePath);
            foreach (SftpFile file in files)
            {
                if ((file.Name != ".") && (file.Name != ".."))
                {
                    string sourceFilePath = sourceRemotePath + "/" + file.Name;
                    string destFilePath = Path.Combine(destLocalPath, file.Name);
                    if (file.IsDirectory)
                    {
                        DownloadDirectory(sftpClient, sourceFilePath, destFilePath);
                    }
                    else
                    {
                        using (Stream fileStream = File.Create(destFilePath))
                        {
                            sftpClient.DownloadFile(sourceFilePath, fileStream);
                        }
                    }
                }
            }
        }

        public void startMinecraft()
        {
            Process.Start(gamePath);
            //Process.Start(@"C:\Program Files\Java\jre1.8.0_261\bin\java.exe - Xmx1G - Djava.library.path = C:\Users\eas1ly\AppData\Roaming\.minecraft\versions\Forge 1.12.2\natives\ -cp C:\Users\eas1ly\AppData\Roaming\.minecraft\versions\Forge 1.12.2\Forge 1.12.2.jar; --assetIndex 1.8 --uuid 1a2b3c4d5e6f7g8h9i0g --accessToken 1a2b3c4d5e6f7g8h9i0g --userProperties {" + "twitch_access_token"+ ":[" + "1a2b3c4d5e6f7g8h9i0g" + "]} --userType mojang --server s24.joinserver.ru --port 25750 --height 480--width 854");
        }
    }
}
