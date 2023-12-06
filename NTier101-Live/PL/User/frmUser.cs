using Microsoft.Data.SqlClient;
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
        private datUserBLL datUserBLL;
        private datUserPoco datUserPoco1;

        public string query;

        clsDBOperation clsDBOperation = new clsDBOperation();

        public frmUser()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //grpbUser.Enabled = false;

            query = "SELECT * FROM datUser WHERE UserID > 0"; // ?? parametrik

            SqlParameter[] sqlParameters = new SqlParameter[1];

            // Tanımlanıyor
            sqlParameters[0] = new SqlParameter("UserID", SqlDbType.SmallInt);
            // Değerler atanıyor
            sqlParameters[0].Value = 0;

            clsDBOperation.executeSelectQuery(query, sqlParameters);

            ShowRecords(); // DG yi dolduracak
        }

        void ShowRecords()
        {
            //DataTable datUser = new DataTable();

            //SqlDataAdapter adapter = new SqlDataAdapter(query);

            //adapter.Fill(datUser);

            //BindingSource bindingSource = new BindingSource();

            //bindingSource.DataSource = datUser; // DG nin sourceu olarak kullanacağım...

            //dgrdUser.DataSource = bindingSource;

            //-----------------

            using (SqlConnection connection = new SqlConnection(@"Data Source=BABEGT\SQLEXPRESS;Initial Catalog=NTier101Db;Integrated Security=True;TrustServerCertificate=True;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter1 = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter1.Fill(dset);

                            dgrdUser.DataSource = dset.Tables[0];

                        }
                    }
                }

            }
        }

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

        private void BindGrid()
        {
            // VT nındaki bilgileri alıp DG içine gömmek için

            //using (SqlConnection connection = new SqlConnection(@"Data Source=BILCE\\ARIBILGI;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=True;Encrypt=False;"))

            string vs_SQLCommand = "SELECT * FROM dat_User";

            using (SqlConnection connection = new SqlConnection(@"Data Source=BABEGT\SQLEXPRESS;Initial Catalog=NTier101Db;Integrated Security=True;TrustServerCertificate=True;"))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            dgrdUser.DataSource = dset.Tables[0];

                        }
                    }
                }

            }
        }


        private void ShowData(string prmMode)
        {
            //frmADO_Detail frmADO_Detail = new frmADO_Detail();

            //frmADO_Detail.Mod = prmMode;

            //// IUD durumuna göre ekran komponent ayarları yapılıyor

            //switch (prmMode)
            //{
            //    case "I": // Insert Modu için
            //        frmADO_Detail.tboxCustomerID.Enabled = true;
            //        frmADO_Detail.tboxCustomerID.Text = "";
            //        frmADO_Detail.tboxCompanyName.Text = "";
            //        frmADO_Detail.tboxContactName.Text = "";
            //        frmADO_Detail.tboxCountry.Text = "";

            //        break;

            //    case "U": // Update Modu için
            //        frmADO_Detail.tboxCustomerID.Enabled = false;
            //        // dg üzerindeki ilgili alanlardaki veriler detay formunun ilgili yerlerine yerleştiriliyor
            //        frmADO_Detail.tboxCustomerID.Text = dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
            //        frmADO_Detail.tboxCompanyName.Text = dgrdCustomers.CurrentRow.Cells[1].Value.ToString();
            //        frmADO_Detail.tboxContactName.Text = dgrdCustomers.CurrentRow.Cells[2].Value.ToString();
            //        frmADO_Detail.tboxCountry.Text = dgrdCustomers.CurrentRow.Cells[3].Value.ToString();

            //        break;

            //    default:
            //        break;
            //}

            //frmADO_Detail.ShowDialog();
        }

        private void dgrdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            BindGrid(); // Gridi yeni datayla doldurmak için

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
    }
}
