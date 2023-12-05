using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NTier101_Live
{
    internal class clsDBOperation
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection Connection { get; set; }

        // Constructor
        public clsDBOperation()
        {
            dataAdapter = new SqlDataAdapter(); 
            Connection = new SqlConnection(@"Data Source=BABEGT\SQLEXPRESS;Initial Catalog=NTier101Db;Integrated Security=True;TrustServerCertificate=True;");
        }

        private SqlConnection openConnection()
        {
            // vt ile olan bağlantıyı acmak ve durumu geri göndermek (acıldı mı / acılmadı mı)

            // bağlantı durumu kontrol ediliyor (kapalı mı  değil mi)
            if (Connection.State==ConnectionState.Closed)
            {
                Connection.Open(); 
            }

            return Connection;
        }
        
        // Klasik CRUD İşlemleri
        // Select kısmı
        public DataTable executeSelectQuery(string _query, SqlParameter[] _parameters)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            DataSet ds = new DataSet();

            dt = null;

            // SQL sorgumu çalıştıracak bölüm
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(_parameters);
                sqlCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand= sqlCommand;
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hata : " + e.ToString);

                return null;

            }


            return dt;
        }

        // Insert kısmı
        public bool executeInsertQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand sqlCommand= new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(_parameters);
                dataAdapter.InsertCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hata : " + e.ToString);

                return false;

            }


            return true;
        }

        // Update kısmı
        public bool executeUpdateQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(_parameters);
                dataAdapter.UpdateCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hata : " + e.ToString);

                return false;

            }


            return true;
        }

        // Delete kısmı
        public bool executeDeleteQuery(string _query)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                dataAdapter.DeleteCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hata : " + e.ToString);

                return false;

            }

            return true;
        }
    }
}
