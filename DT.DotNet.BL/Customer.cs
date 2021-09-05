using DT.DotNet.Common;
using System;
using System.Collections.Generic;

namespace DT.DotNet.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
                    
        }

        public Customer(int customerId)
        {
            CustormerId = customerId;
            Addresses = new List<Address>();
        }

        #region Properties

        public int CustormerId { get; private set; } // Relation - composition - (has) - id

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public string EmailAddress { get; set; }

        public static int InstanceCounter { get; set; }

        public List<Address> Addresses { get; set; } // Relation - composition - (has) - reference

        public int CustomerType { get; set; }

        #endregion Properties

        #region Methods

        public override bool Validate() // inheritance-based polymorphism
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;

            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString() => FullName; // inheritance-based polymorphism

        public string Log() => $"{CustormerId}: {FullName} - Email: {EmailAddress}"; // interface-based polymorphism

        #endregion Methods
    }
}
