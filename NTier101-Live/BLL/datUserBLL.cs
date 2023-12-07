using NTier101_Live.DAL;
using NTier101_Live.PocosL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live.BLL
{
    public class datUserBLL
    {
        private datUserDAO datUserDAO;

        // constuctor
        public datUserBLL()
        {
            datUserDAO = new datUserDAO();
        }

        // Parametrik sorgulama sonrası istenen kullanıcı kaydını getirme


        // Login ekranından girilen bilgilere göre datUser tablosunda uygun bir kayıt var/yok?
        public datUserPoco getQuery(string username,string userpassw)
        {
            datUserPoco datUserPoco= new datUserPoco();

            DataTable dataTable= new DataTable();

            dataTable= datUserDAO.searchUserIDPassw(username,userpassw);

            foreach (DataRow row in dataTable.Rows)
            {
                datUserPoco.UserName = row["UserName"].ToString();
                datUserPoco.UserPassw = row["UserPassw"].ToString();
            }

            return datUserPoco; // varsa çağıran katmana gönder
        } 

        public datUserPoco insertUser(string UserName, string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID)
        {
            datUserPoco datUserPoco= new datUserPoco();
            DataTable dataTable =new DataTable();

            datUserDAO.insertUser(UserName,UserPassw,Ad,Soyad,TCKimlik,MudurlukID);

            foreach (DataRow row in dataTable.Rows)
            {
                row["UserName"]=datUserPoco.UserName;
                row["UserPassw"] = datUserPoco.UserPassw;
                row["Ad"] = datUserPoco.Ad;
                row["Soyad"] = datUserPoco.Soyad;
                row["TCKimlik"] = datUserPoco.TCKimlik;
                row["MudurlukID"] = datUserPoco.MudurlukID;
            }

            return datUserPoco;
        }
    }
}
