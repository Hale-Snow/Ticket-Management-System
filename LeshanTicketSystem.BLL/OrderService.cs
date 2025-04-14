using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeshanTicketSystem.DAL;

namespace LeshanTicketSystem.BLL
{
    public class OrderService
    {
        private OrderDataAcces orderDataAccess;

        public OrderService()
        {
            orderDataAccess = new OrderDataAcces();
        }

        public DataTable GetOrders()
        {
            try
            {
                // 从 DAL 层获取订单数据
                return orderDataAccess.GetOrders();
            }
            catch (ApplicationException ex)
            {
                // 捕获异常，并将其传递到 UI 层处理
                throw new ApplicationException("Failed to load orders: " + ex.Message, ex);
            }
        }
    }
}
