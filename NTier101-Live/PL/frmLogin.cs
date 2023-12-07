using NTier101_Live.BLL;
using NTier101_Live.PocosL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmLogin : Form
    {
        datUserBLL datUserBLL = new datUserBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label3.Text = label3.Text.ToUpper();
        }

        private void btonLogin_Click(object sender, EventArgs e)
        {
            datUserPoco datUserPocoScreen= new datUserPoco();

            datUserPocoScreen = datUserBLL.getQuery(tboxUserName.Text, tboxUserPassw.Text);

            if (datUserPocoScreen.UserName == null || datUserPocoScreen.UserPassw == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen kontrol ediniz...");
            }
            else
            {
                this.Hide();

                frmMain frmMain = new frmMain();

                frmMain.Text= "Hoşgeldiniz sayın " + datUserPocoScreen.Ad + " " + datUserPocoScreen.Soyad + " - "+ datUserPocoScreen.MudurlukID.ToString() + " - İyi çalışmalar dileriz...";
                
                frmMain.Show();
            }
        }
    }
}
