using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live.DAL
{
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






    }
}
