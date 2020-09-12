using loaderMinecraft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaderMinecraft
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        string pathLauncher = Settings.Default["pathLauncher"].ToString();
        string pathMod = Settings.Default["pathMods"].ToString();
        dowloand dw = new dowloand();

        void load_Load(object sender, EventArgs e)
        {
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
            Console.ReadLine();
        }

        void playButt_Click(object sender, EventArgs e)
        {
            try
            {
                dw.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка запуска.", MessageBoxButtons.OK);
            }
        }

        void delButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить все установленные моды?","Подтвреждение удаления.",MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                проверкаМодов();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка проверки.", MessageBoxButtons.OK);
            }
        }

        private void load_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
