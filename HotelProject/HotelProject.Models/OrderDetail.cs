using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public OrderHeader OrderHeader { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public decimal Price { get; set; }
        public int TotalDays { get; set; }
    }
}
