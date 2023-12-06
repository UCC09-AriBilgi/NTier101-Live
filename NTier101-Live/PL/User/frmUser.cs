using Microsoft.Data.SqlClient;
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
    public partial class frmUser : Form
    {
        public SqlCommand query;

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
            clsDBOperation clsDBOperation = new clsDBOperation();

            query = new SqlCommand("SELECT * FROM datUser", clsDBOperation.Connection);

            ShowRecords(); // DG yi dolduracak






        }

        void ShowRecords()
        {
            DataTable datUser = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.Fill(datUser);

            BindingSource bindingSource = new BindingSource();

            bindingSource.DataSource = datUser; // DG nin sourceu olarak kullanacağım...

            dgrdUser.DataSource=bindingSource;
        }
    }
}
