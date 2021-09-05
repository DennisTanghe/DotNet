using DT.DotNet.BL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DT.DotNet.Repository
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository; // Relation - collaborative (uses)

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int id) // Relation - collaborative (uses)
        {
            // To replace with data access coding
            var customer = new Customer(id);
            customer.LastName = "Baggins";
            customer.FirstName = "Frodo";
            customer.EmailAddress = "frodo@baggins.com";
            customer.Addresses = _addressRepository.RetrieveByCustomerId(id).ToList();

            return customer;
        }

        public List<Customer> Retrieve() // Relation - collaborative (uses)
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
