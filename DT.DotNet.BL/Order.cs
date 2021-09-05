using DT.DotNet.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.BL
{
    public class Order: EntityBase, ILoggable
    {
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            Id = orderId;
            OrderItemList = new List<OrderItem>();
        }

        public int Id { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        public int CustomerId { get; set; } // Relation - composition - (has)

        public int ShippingAddressId { get; set; } // Relation - composition - (has)

        public List<OrderItem> OrderItemList { get; set; } // Relation - composition - (has)

        public override bool Validate()
        {
            return true;
        }

        public override string ToString() => $"{OrderDate.Value.DateTime} - {Id}";

        public string Log() => $"{Id}: {OrderDate.Value}";
    }
}
