using LeshanTicketSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeshanTicketSystem.BLL
{
    public class SalesChartManager
    {
        private readonly SalesDAL salesDal = new SalesDAL();

        // 获取销售数据
        public DataTable GetSalesData()
        {
            return salesDal.GetDailySales();
        }
    }
}
