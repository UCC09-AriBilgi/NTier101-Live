using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using NTier101_Live.BLL;
using NTier101_Live.PocosL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NTier101_Live.PL.User
{
    public partial class frmUser : Form
    {
        private datUserBLL datUserBLL = new datUserBLL();
        private datUserPoco datUserPoco1;

        private SqlCommand query;

        public string Mode; // Kullanıcı üzerinde yapılacak işlemin ne olduğu (I;U;D)

        public int UserID;

        public frmUser()
        {
            InitializeComponent();
        }

        #region Form Methods

        private void frmUser_Load(object sender, EventArgs e)
        {
            FormInit();

            ShowRecords();

        }

        #endregion

        #region Button Events
        
        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            //grpbUser.Enabled = true;
            //tboxUserName.Focus();

            datUserPoco datUserPoco = new datUserPoco();
            datUserBLL = new datUserBLL();

            // BLL tarafındaki User ile ilgili classımdaki kullanı kayıt metodunu kullanak datUserPoco isimli classıma yükleme yapacağım.

            datUserPoco = datUserBLL.insertUser(tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

            MessageBox.Show("Kullanıcı kaydınız yapılmıştır...");

            Temizle();// ekrandaki eski bilgiler temizleniyor.
            ShowRecords(); // Gridi yeni datayla doldurmak için

        }

        private void pboxNew_Click(object sender, EventArgs e)
        {
            Mode = "I"; // Insert modu

            grpbUser.Enabled = true;

            tboxUserName.Focus(); // fare imlecini ilgili kontrole koyuyor.
        }

        private void btonSave_Click_1(object sender, EventArgs e)
        {
            IUD();

        }

        private void pboxUpdate_Click(object sender, EventArgs e)
        {
            Mode = "U"; // Update modu

            grpbUser.Enabled = true;

            UserID = Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value);

            datUserPoco datUserPoco = new datUserPoco();

            datUserPoco = datUserBLL.getUser(UserID); // UserID si belirli olan kaydı tablodan çekecek ve bunları ekranda boş duram componentlere dolduracağız...

            tboxUserName.Text = datUserPoco.UserName;
            tboxUserPassw.Text = datUserPoco.UserPassw;
            tboxAd.Text = datUserPoco.Ad;
            tboxSoyad.Text = datUserPoco.Soyad;
            tboxTCKimlik.Text = datUserPoco.TCKimlik;
            tboxMudurlukID.Text = datUserPoco.MudurlukID.ToString();


            tboxUserName.Focus(); // fare imlecini ilgili kontrole koyuyor.
        }

        private void pboxDelete_Click(object sender, EventArgs e)
        {
            Mode = "D"; // Delete modu

            UserID = Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value);

            IUD();

        }
        
        #endregion

        #region DataGrid Events
        
        private void dgrdUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //query = new SqlCommand("SELECT * FROM datUser WHERE UserID=" + dgrdUser.CurrentRow.Cells[0].Value, clsDBOperation.Connection);

            grpbUser.Enabled = true;

            tboxUserName.Text = "";
            tboxUserPassw.Text = "";
            tboxAd.Text = "";
            tboxSoyad.Text = "";
            tboxTCKimlik.Text = "";
            tboxMudurlukID.Text = "";


            // dg üzerinde herhangi bir satırda çift tıklama ile forma gitme...
            //ShowData("U"); // 3 ayrı işlemi (I,U,D) tek metotda birleştiren benim yazdığım metot
            //BindGrid();
        }



        private void dgrdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region General Methods
        // DG yi dolduracak olan metot
        void ShowRecords()
        {
            clsDBOperation conn = new clsDBOperation();

            query = new SqlCommand("SELECT * FROM datUser", conn.Connection);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();

            bindingSource.DataSource = dataTable;

            dgrdUser.DataSource = bindingSource;


        }

        // Form ilk açıldığında gerekli ayarları yapıyor.
        public void FormInit()
        {
            Mode = "";

            tboxUserName.Clear();
            tboxUserPassw.Clear();
            tboxAd.Clear();
            tboxSoyad.Clear();
            tboxTCKimlik.Clear();
            tboxMudurlukID.Clear();

            grpbUser.Enabled = false;

            ShowRecords();
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

        // I U D işlemlerini tek bir metotda hallediyor
        private void IUD()
        {
            datUserPoco datUserPoco = new datUserPoco();

            switch (Mode)
            {
                case "I":
                    datUserPoco = datUserBLL.insertUser(tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

                    MessageBox.Show("Kayıt işlemi başarılı...");

                    break;

                case "U":
                    datUserPoco = datUserBLL.updateUser(Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value), tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

                    MessageBox.Show("Güncelleme işlemi başarılı...");

                    break;

                case "D":
                    datUserPoco = datUserBLL.deleteUser(Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value));

                    MessageBox.Show("Silme işlemi başarılı...");

                    break;

                default:
                    break;
            }

            Temizle();

            ShowRecords();
        }

        #endregion
















    }
}
