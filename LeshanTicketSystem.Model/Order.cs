using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeshanTicketSystem.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string IdCard { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
    }
}
