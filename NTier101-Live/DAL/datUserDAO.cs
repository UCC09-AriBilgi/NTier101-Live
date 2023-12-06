using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NTier101_Live.DAL
{
    // DB tabloları üzerinde gerekli işlemleri gerrçekleştiren bir sınıf
    // UserID-Passw e göre kullanıcıyı arama
    // Gelen bilgilere göre de
    // Insert,Update,Delete işlemlerini gerçekleştirecek


    internal class datUserDAO
    {
        private clsDBOperation clsDBOperation;

        // constructor
        public datUserDAO()
        {
            clsDBOperation = new clsDBOperation();
        }

        // Bir kullanıcının ceşitli bilgilerinin searchj edileceği bir durum
        // Sisteme giriş için kullanılacak

        public DataTable searchUserIDPassw(string userName,string userPassw)
        {
            string Query = string.Format("SELECT * FROM datUser WHERE UserName=@UserName AND UserPassw=@UserPassw");

            SqlParameter[] sqlParameters=new SqlParameter[2];

            // Tanımlanıyor
            sqlParameters[0]= new SqlParameter("UserName",SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);

            // Değerler atanıyor
            sqlParameters[0].Value = userName;
            sqlParameters[1].Value = userPassw;

            return clsDBOperation.executeSelectQuery(Query,sqlParameters);
        }

        // Kullanıcı ekleme
        public bool insertUser(string UserName,string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID)
        {
            string query;

            query = "INSERT INTO datUser ";
            query += "(UserName,UserPassw,Ad,Soyad,TCKimlik,MudurlukID) VALUES ";
            query += "(@UserName,@UserPassw,@Ad,@Soyad,@TCKimlik,@MudurlukID)";

            SqlParameter[] sqlParameters = new SqlParameter[6];

            // Tanımlanıyor
            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);

            // Değerler atanıyor
            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad;
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;

            return clsDBOperation.executeInsertQuery(query,sqlParameters);
        }

        // Kullanıcı güncelleme
        public bool updateUser(int UserID,string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            string query;

            query = "UPDATE datUser ";
            query += "SET ";
            query += "UserName=@UserName,";
            query += "UserPassw=@UserPassw,";
            query += "Ad=@Ad,";
            query += "Soyad=@Soyad,";
            query += "TCKimlik=@TCKimlik,";
            query += "MudurlukID=@MudurlukID ";
            query += "WHERE UserID=@UserID";

            SqlParameter[] sqlParameters = new SqlParameter[7];

            // Tanımlanıyor
            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);
            sqlParameters[6] = new SqlParameter("UserID", SqlDbType.SmallInt);

            // Değerler atanıyor
            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad;
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;
            sqlParameters[6].Value = UserID;

            return clsDBOperation.executeUpdateQuery(query, sqlParameters);

        }

        // Kullanıcı Silme
        public bool deleteUser(int UserID)
        {
            string query;

            query = "DELETE datUser WHERE UserID=" + UserID.ToString();

            return clsDBOperation.executeDeleteQuery(query);
        }





    }
}
