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
    // Bu class yönlendirici bir classdır. Yani bir trafik polisi gibi.Sen şu işi yapacaksan şuraya, bu işi yapacaksan buraya git gibi yönlendirmeleri yapıyor. İlerde bunu Controller(MVC tarafında) olarak adlandıracağız.
    
    public class datUserBLL
    {
        private datUserDAO datUserDAO;

        // constuctor
        public datUserBLL()
        {
            datUserDAO = new datUserDAO();
        }

        // Parametrik sorgulama sonrası istenen kullanıcı kaydını getirme
        public datUserPoco getUser(int UserID)
        {
            datUserPoco datUserPoco = new datUserPoco();

            DataTable dataTable = new DataTable();

            // Data Access yapan objeme git . Oradaki getUser isimli metodu calıtır.
            dataTable = datUserDAO.getUser(UserID);

            // gelen datatable nesnesindeki propertyleri ilgili datUserPoco isimli clasın propertylerine gececek ki diğer classlarda da kullanabileyim.
            foreach (DataRow row in dataTable.Rows)
            {
                datUserPoco.UserName = row["UserName"].ToString();
                datUserPoco.UserPassw = row["UserPassw"].ToString();
                datUserPoco.Ad = row["Ad"].ToString();
                datUserPoco.Soyad = row["Soyad"].ToString();
                datUserPoco.TCKimlik = row["TCKimlik"].ToString();
                datUserPoco.MudurlukID = Convert.ToInt32(row["MudurlukID"].ToString());

            }

            return datUserPoco; // Çağıran yere classı gönder

        }


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
                datUserPoco.Ad = row["Ad"].ToString();
                datUserPoco.Soyad = row["Soyad"].ToString();
                datUserPoco.MudurlukID = Convert.ToInt32(row["MudurlukID"].ToString());
            }

            return datUserPoco; // varsa çağıran katmana gönder
        } 

        // DAO sınıfındaki işi yapacak ilgili metodu çağırıyor
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

        public datUserPoco updateUser(int UserID, string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            datUserPoco datUserPoco = new datUserPoco();

            DataTable dataTable =new DataTable();

            datUserDAO.updateUser(UserID, UserName, UserPassw, Ad, Soyad, TCKimlik, MudurlukID);


            return datUserPoco;

        }

        public datUserPoco deleteUser (int UserID) 
        {
            datUserPoco datUserPoco = new datUserPoco();

            DataTable dataTable = new DataTable();

            datUserDAO.deleteUser(UserID);


            return datUserPoco;

        }
    }
}
