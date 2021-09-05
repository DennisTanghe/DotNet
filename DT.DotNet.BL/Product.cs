using DT.DotNet.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            Id = productId;
        }

        public int Id { get; private set; }

        private string _name;
        public string Name { 
            get
            {
                return _name.InsertSpaces();
            }
            set
            {
                _name = value;
            }
        }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => Name;

        public string Log() => $"{Id}: {Name}";
    }
}
