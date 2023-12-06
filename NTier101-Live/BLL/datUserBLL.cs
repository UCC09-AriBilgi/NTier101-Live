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

        public datUserPoco getQuery(string username,string userpassw)
        {
            // Login ekranı için

            datUserPoco datUserPoco= new datUserPoco();

            DataTable dataTable= new DataTable();

            dataTable= datUserDAO.searchUserIDPassw(username,userpassw);

            foreach (DataRow row in dataTable.Rows)
            {
                datUserPoco.UserName = row["UserName"].ToString();
                datUserPoco.UserPassw = row["UserPassw"].ToString();
            }

            return datUserPoco;
        } 



    }
}
