using LeshanTicketSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeshanTicketSystem.BLL
{
    public class TouristBLL
    {
        private TouristDAL dal = new TouristDAL();

        public DataTable GetTouristList()
        {
            return dal.GetAllTourists();
        }


        public static bool DeleteTouristByIdCard(string idCard)
        {
            return TouristDAL.DeleteByIdCard(idCard);
        }

        public static bool UpdateTouristStatus(string idCard, int status)
        {
            return TouristDAL.UpdateStatus(idCard, status);
        }

        //搜索游客
        public DataTable SearchTourists(string keyword, string status)
        {
            TouristDAL dal = new TouristDAL();
            return dal.SearchTourists(keyword, status);
        }



    }
}
