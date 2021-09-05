using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderId)
        {
            Id = orderId;
        }

        public int Id { get; private set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem(id);
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
