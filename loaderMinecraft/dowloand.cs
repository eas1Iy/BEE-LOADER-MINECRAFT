using BEE.Properties;
using Renci.SshNet;
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
        List<string> serverMods;
        public bool fix;
        Thread ss;



        void dowloand_Load(object sender, EventArgs e)
        {
            DownloadAll();
        }

        public void DownloadAll()
        {
            ss = new Thread(DownloadAll1);
            ss.Start();
        }


        public async void DownloadAll1() // способ №1 - ошибка с паролем.
        {
            string remoteDirectory = "/user_mods/";
            string localDirectory = Convert.ToString(Settings.Default["pathMods"] + @"\");

            //
            serverMods = new List<string>();
            try
            {
                //Моды с фтп
                using (var sftp = new SftpClient("s24.joinserver.ru", 2022, "y5bq0wrk.b11838bf", "brN-eNb-eKq-B7y"))
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
                using (var sftp = new SftpClient("s24.joinserver.ru", 2022, "y5bq0wrk.b11838bf", "brN-eNb-eKq-B7y"))
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

                                sftp.DownloadFile(remoteDirectory + s, file1);
                            }
                        }
                    }
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
        public void startMinecraft()
        {
            Process.Start(gamePath);
            //Process.Start(@"C:\Program Files\Java\jre1.8.0_261\bin\java.exe - Xmx1G - Djava.library.path = C:\Users\eas1ly\AppData\Roaming\.minecraft\versions\Forge 1.12.2\natives\ -cp C:\Users\eas1ly\AppData\Roaming\.minecraft\versions\Forge 1.12.2\Forge 1.12.2.jar; --assetIndex 1.8 --uuid 1a2b3c4d5e6f7g8h9i0g --accessToken 1a2b3c4d5e6f7g8h9i0g --userProperties {" + "twitch_access_token"+ ":[" + "1a2b3c4d5e6f7g8h9i0g" + "]} --userType mojang --server s24.joinserver.ru --port 25750 --height 480--width 854");
        }
    }
}
