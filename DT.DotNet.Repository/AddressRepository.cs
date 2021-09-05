using DT.DotNet.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(int id)
        {
            var address = new Address(id)
            {
                StreetLine1 = "Street line 1",
                StreetLine2 = "Street line 2",
                PostalCode = "1234",
                City = "The City",
                StateProvince = "The Province",
                Country = "The Country",
                Type = id == 1 ? "Home" : "Work"
            };

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>()
            {
                new Address(1)
                {
                    StreetLine1 = "Street line 1",
                    StreetLine2 = "Street line 2",
                    PostalCode = "1234",
                    City = "The City",
                    StateProvince = "The Province",
                    Country = "The Country",
                    Type = "Home"
                },
                new Address(2)
                {
                    StreetLine1 = "Street line 1",
                    StreetLine2 = "Street line 2",
                    PostalCode = "1234",
                    City = "The City",
                    StateProvince = "The Province",
                    Country = "The Country",
                    Type = "Work"
                }
            };

            return addressList;
        }

        public bool Save()
        {
            return true;
        }
    }
}
