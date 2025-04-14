using LeshanTicketSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeshanTicketSystem.Model;
using System.Threading.Tasks;
using System.Data;

namespace LeshanTicketSystem.BLL
{
    public static class OrderBLL
    {
        public static bool DeleteOrderById(int orderid)
        {
            return OrderDAL.DeleteById(orderid);
        }

        public static bool UpdateOrder(Order order)
        {
            return OrderDAL.UpdateOrder(order);
        }

        public static bool InsertOrder(Order order)
        {
            return OrderDAL.InsertOrder(order); // 调用数据访问层插入方法
        }

        //数据搜索
        public static DataTable SearchOrders(string keyword)
        {
            return OrderDAL.SearchOrders(keyword);
        }

    }
}
