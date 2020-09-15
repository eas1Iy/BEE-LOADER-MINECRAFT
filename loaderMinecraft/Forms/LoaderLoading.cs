using Renci.SshNet;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaderMinecraft
{
    public partial class LoaderLoading : Form
    {
        public LoaderLoading()
        {
            InitializeComponent();
        }

        public string lastUpdate;

        bool inet()
        {
            if (Internet.CheckConnection())
                return true;
            else
                return false;
        }

        bool listUpdate()
        {
            if (inet() == true)
            {
                using (var sftp = new SftpClient("s24.joinserver.ru", 2022, "y5bq0wrk.b11838bf", "brN-eNb-eKq-B7y"))
                {
                    try
                    {
                        Stream vers = File.OpenWrite(@"temp_update.ini");
                        sftp.Connect();
                        sftp.DownloadFile(@"/LOADER/update.txt", vers);
                        vers.Dispose();
                        lastUpdate = File.ReadAllText(@"temp_update.ini");
                        if (File.Exists(@"temp_update.ini"))
                        {
                            update.Text = lastUpdate;
                            _anim.Hide(_updateLoading);
                            _anim.Show(update);
                        }
                        File.Delete(@"temp_update.ini");
                        sftp.Disconnect();
                    }
                    catch { }
                }
                    return true;
            }
            else
            {
                return false;
            }
                
        }

        bool updates()
        {
            if (inet() == true)
            {
                using (var sftp = new SftpClient("s24.joinserver.ru", 2022, "y5bq0wrk.b11838bf", "brN-eNb-eKq-B7y"))
                {
                    Stream vers = File.OpenWrite(@"temp_version.ini");
                    sftp.Connect();
                    sftp.DownloadFile(@"/LOADER/version.txt", vers);
                    vers.Dispose();
                    string actualVers = File.ReadAllText(@"temp_version.ini");
                    string lblver = Application.ProductVersion; //Локальная версия лаунчера, та которая на данный момент
                    if (File.Exists(@"temp_version.ini")) //Проверим есть ли только что скаченый файл актуальной версии? для того чтобы понять ,скачался ли он
                    {

                        Thread.Sleep(500);

                        if (Application.ProductVersion.ToString() == actualVers) // Сверяем версии. Тут нужно учесть, что идет проверка string не int значений, поэтому если будет отличие в точке, версия будет другой
                        {
                            File.Delete(@"temp_version.ini");
                            return true;
                        }
                        else
                        {
                            try
                            {
                                string aprod = File.ReadAllText(@"temp_version.ini");  // Повышеная версия программы для удаления
                                //MessageBox.Show("Внимание! \nСейчас начнётся обновление программы: BEE LOADER\nВ случае если у вас запросят права администратора, разрешите нажав 'Да'.", "- Обновление", MessageBoxButtons.OK); // Качаем программу

                                Stream program = File.OpenWrite(Application.ProductName + "(" + actualVers + ")" + @".exe");
                                sftp.DownloadFile(@"/LOADER/loader.exe", program);

                                Process pc = new Process();
                                //pc.StartInfo.Verb = "runas"; //Если снять коментарий, CMD запустится от имени Админа, и в этом случае нужно будет указать полные пути. Типа Enveroment.CurrentDirectory
                                pc.StartInfo.FileName = "cmd";
                                pc.StartInfo.CreateNoWindow = true;
                                pc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                                Process.Start(Application.ProductName + "(" + actualVers + ")" + @".exe");
                                pc.StartInfo.Arguments = " / c @ECHO OFF && ping -n 3 127.0.0.1 && del "+Application.ProductName+"("+Application.ProductVersion+")"+@".exe  / f / q ";
                                //pc.StartInfo.Arguments = " / c @ECHO OFF && ping -n 3 127.0.0.1 && start " + Application.ProductName + "(" + actualVers + ")" + @".exe && del " + Application.ProductName + "(" + Application.ProductVersion + ")" + @".exe  / f / q ";

                                pc.Start();

                                sftp.Disconnect();
                                File.Delete(@"temp_version.ini");
                                Application.Exit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                                Application.Exit();
                            }
                        }
                    }
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Подключение к серверу отсутствует." +
                    "\nВозможные причины:" +
                    "\n1. У вас отсутствует подключение к интернету." +
                    "\n2. На сервере ведутся технические работы." +
                    "\n3. Брандмауэр блокирует соединение ПО с интернетом.", "- Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }

        async void LoaderLoading_Load(object sender, EventArgs e)
        {
            _anim.Show(pictureBox1);
            if (await Task.Run(() => listUpdate()))
            {
                if (await Task.Run(() => updates()) == true)
                {
                    load lzd = new load();
                    lzd.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Ошибка получения данных об обновлении!", "Ошибка", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}