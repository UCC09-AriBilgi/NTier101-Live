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

namespace NTier101_Live.PL.User
{

    public partial class frmUserInsert : Form
    {
        private datUserBLL datUserBLL;

        public frmUserInsert()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            datUserPoco datUserPoco = new datUserPoco();
            datUserBLL = new datUserBLL();

            // BLL tarafındaki User ile ilgili classımdaki kullanı kayıt metodunu kullanak datUserPoco isimli classıma yükleme yapacağım.
            datUserPoco = datUserBLL.insertUser(tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

            MessageBox.Show("Kullanıcı kaydınız yapılmıştır...");

            Temizle();// ekrandaki eski bilgiler temizleniyor.

        }

        void Temizle()
        {
            tboxUserName.Clear();
            tboxUserPassw.Clear();
            tboxAd.Clear();
            tboxSoyad.Clear();
            tboxTCKimlik.Clear();
            tboxMudurlukID.Clear();
        }

        private void frmUserInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
