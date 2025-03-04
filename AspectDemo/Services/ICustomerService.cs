﻿using AspectDemo.Models;

namespace AspectDemo.Services
{
    public interface ICustomerService
    {
       List<Customer> GetCustomers();
       Customer GetCustomer(int id);
       int AddCustomer(Customer customer);
       int UpdateCustomer(int id, Customer customer);
       int DeleteCustomer(int id);
    }
}
