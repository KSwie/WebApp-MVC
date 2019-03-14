using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SendDate { get; set; }
    }
}
