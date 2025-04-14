using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeshanTicketSystem.Model;
using LeshanTicketSystem.DAL;

namespace LeshanTicketSystem.BLL
{
    public class AdminBLL
    {
        private AdminDAL adminDAL = new AdminDAL();

        public bool Login(string uid, string password, out Admin admin)
        {
            admin = adminDAL.GetAdminByUidAndPassword(uid, password);
            return admin != null;
        }


        private readonly AdminDAL dal = new AdminDAL();

        public List<string> GetAdminList()
        {
            return dal.GetAllAdmins().Select(a => a.Uid).ToList();
        }

        public bool VerifyPassword(string uid, string inputPassword)
        {
            string realPassword = dal.GetPassword(uid);
            return realPassword == inputPassword;
        }

        public bool UpdatePassword(string uid, string oldPass, string newPass)
        {
            if (!VerifyPassword(uid, oldPass))
                return false;

            if (oldPass == newPass)
                return false;

            dal.UpdatePassword(uid, newPass);
            return true;
        }

        public bool DeleteAdmin(string uid, string inputPassword)
        {
            if (!VerifyPassword(uid, inputPassword))
                return false;

            dal.DeleteAdmin(uid);
            return true;
        }
    }
}
