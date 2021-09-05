using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string StreetLine1 { get; set; }

        public string StreetLine2 { get; set; }

        public string City { get; set; }

        public string StateProvince { get; set;}

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Type { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(PostalCode)) isValid = false;

            return isValid;
        }
    }
}
