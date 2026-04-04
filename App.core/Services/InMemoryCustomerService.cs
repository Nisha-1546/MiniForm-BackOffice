using System;
using System.Collections.Generic;
using System.Text;
using App.core.Contracts;
using App.core.Models;

namespace App.core.Services
{
    public class InMemoryCustomerService:ICustomerService
    {
        private List<Customer> _customer=new List<Customer>();

        List<Customer> ICustomerService.GetAll()
        { 
            return _customer.ToList();
        }
        Customer ICustomerService.GetById(string id)
        {
        return _customer.FirstOrDefault(c=>c.Id==id);
        }
         void ICustomerService.Add(Customer customer) 
        {
            if (customer == null)
                throw new ArgumentNullException("customer object is null");
            _customer.Add(customer);
        }
         void ICustomerService.Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("customer object is null");
            var existing= _customer.FirstOrDefault(c => c.Id == customer.Id);
            if (existing == null)
                throw new Exception($"customer with{customer.Id} id is not found");

            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            existing.Address = customer.Address;
        }
         void ICustomerService.Delete(string id) 
        { 
            _customer.RemoveAll(c=>c.Id == id);
        }
         List<Customer> ICustomerService.Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return ((ICustomerService)this).GetAll();
            return _customer.Where(c=>c.Name.Contains(query,StringComparison.OrdinalIgnoreCase)).ToList();

        }
    }
}
