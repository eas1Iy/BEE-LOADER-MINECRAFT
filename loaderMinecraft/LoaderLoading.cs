using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaderMinecraft
{
    public partial class LoaderLoading : Form
    {
        public LoaderLoading()
        {
            InitializeComponent();
            _animate.SetAnimateWindow(this);
            _shadow.SetShadowForm(this);
        }

        public bool inet()
        {
            if (Internet.CheckConnection())
                return true;
            else
                return false;
        }

        async void LoaderLoading_Load(object sender, EventArgs e)
        {
            await Task.Delay(1200);
            if (inet() == true)
            {
                load ld = new load();
                //
                this.Hide();
                ld.Show();
            }
            else
            {
                MessageBox.Show("Использование загрузчика модов невозможно без соединения с интернетом!\n\n" +
                    "Проверьте ваш брандмауэр и антивирус, они должны быть отключены!","Ошибка соединения.", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
