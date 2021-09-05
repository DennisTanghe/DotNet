using DT.DotNet.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.Repository
{
    public class OrderRepository
    {

        public Order Retrieve(int id)
        {
            var order = new Order(id)
            {
                OrderDate = new DateTimeOffset(2021, 9, 5, 18, 45, 00, new TimeSpan(1, 0, 0))
            };

            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
