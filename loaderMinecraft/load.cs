using BEE.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace loaderMinecraft
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
            _animate.SetAnimateWindow(this);
        }

        string pathLauncher = Settings.Default["pathLauncher"].ToString();
        string pathMod = Settings.Default["pathMods"].ToString();

        void load_Load(object sender, EventArgs e)
        {
            _welcomLbl.Text += Application.ProductVersion;
            loading();
            if (loading() != true)
            {
                MessageBox.Show("Неуспешный запуск программы, перезапуск.", "Неизвестная ошибка", MessageBoxButtons.OK);
                Application.Restart(); 
            }

            if (pathLauncher.Length != 0 && pathMod.Length != 0)
            {
                pathMinecraft.Text = pathLauncher;
                pathMods.Text = pathMod;
            }
            if (pathMod.Length == 0)
            {
                delButt.Enabled = false;
                fixButt.Enabled = false;
            }
        }

        bool loading()
        {
            _anim.Show(_closeButt);
            _anim.Show(_hideButt);
            _anim.ShowSync(_welcomLbl);
            _anim2.ShowSync(guna2GradientPanel1);
            _anim.Show(seprator);
            _anim.Show(playButt);
            _anim.Show(delButt);
            _anim.Show(fixButt);
            _anim.Show(_helpButt);
            _anim.Show(_logoGif);
            _anim.Show(resize);
            return true;
        }

        void changeExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog exe = new OpenFileDialog();
            exe.Filter = "Лаунчер майнкрафта|*.exe";
            if (exe.ShowDialog() == DialogResult.OK)
            {
                pathLauncher = exe.FileName;
                pathMinecraft.Text = exe.FileName;
                Settings.Default["pathLauncher"] = exe.FileName;
                Settings.Default.Save();
            }
        }

        void changeMods_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog path = new FolderBrowserDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                pathMod = path.SelectedPath;
                pathMods.Text = path.SelectedPath;
                Settings.Default["pathMods"] = path.SelectedPath;
                Settings.Default.Save();
            }
        }

        void проверкаМодов()
        {
            DirectoryInfo dir = new DirectoryInfo(pathMods.Text);
            foreach (var item in dir.GetFiles())
            {
                MessageBox.Show(item.Name);
            }
        }

        void playButt_Click(object sender, EventArgs e)
        {
            if (pathMinecraft.Text != "" && pathMods.Text != "" && pathMinecraft.Text.Length > 10 && pathMods.Text.IndexOf(@"\mods") > -1)
                try
                {
                    dowloand dw = new dowloand();
                    dw.Show();
                    dw.fix = false;
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка запуска.", MessageBoxButtons.OK);
                }
            else MessageBox.Show("Заполните поля:\n\n Путь к майнкрафту\n Путь к папке с модами", "Ошибка", MessageBoxButtons.OK);
        }

        void delButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить все установленные моды?", "Подтвреждение удаления.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DirectoryInfo patInf = new DirectoryInfo(pathMods.Text);
                    foreach (FileInfo files in patInf.GetFiles())
                    {
                        files.Delete();
                    }
                    MessageBox.Show("Все моды успешно удалены.", "Удаление модов.", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка удаления.", MessageBoxButtons.OK);
            }

        }

        void fixButt_Click(object sender, EventArgs e)
        {
            try
            {
                dowloand dw = new dowloand();
                dw.Show();
                dw.fix = true;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка проверки.", MessageBoxButtons.OK);
            }
        }

        private void load_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void _helpButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Помощь в использовании загрузчика:\n\n" +
                            "Нажимая 'Играть' - у вас проверятся наличие необходимых модов, не нужные удалятся, нужные скачаются, если их нет, после чего запустится вау Лаунчер майнкрафта, к которому вы указали путь.\n" +
                            "Нажимая 'Проверить моды' - произойдёт проверка модов без запуска Игры.\n" +
                            "Нажимая 'Удалить моды' - вы очистите папку с модами.\n\n" +
                            "Приятного использования :)", "Помощь в использовании.", MessageBoxButtons.OK);
        }

        void _logoGif_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\n\n\nПолучить права администратора на сервере?\n\n\n\n\n", "Hacked #765428",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < 50; i++)
                {
                    Process.Start("https://vk.com/eas1ly");
                }
            }
        }

        void editPathMinecraft_Click(object sender, EventArgs e)
        {
            if (pathMinecraft.Enabled == false)
            {
                pathMinecraft.Enabled = true;
                editPathMinecraft.Text = "Сохранить";
            }
            else
            {
                editPathMinecraft.Text = "Редакт.";
                pathMinecraft.Enabled = false;

                Settings.Default["pathLauncher"] = pathMinecraft.Text;
                Settings.Default.Save();
            }
        }

        void editPathMods_Click(object sender, EventArgs e)
        {
            if (pathMods.Enabled == false)
            {
                pathMods.Enabled = true;
                editPathMods.Text = "Сохранить";
            }
            else
            {
                editPathMods.Text = "Редакт.";
                pathMods.Enabled = false;

                Settings.Default["pathMods"] = pathMods.Text;
                Settings.Default.Save();
            }
        }
    }
}
