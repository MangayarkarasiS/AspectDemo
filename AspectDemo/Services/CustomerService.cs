using AspectDemo.Aspects;
using AspectDemo.Exceptions;
using AspectDemo.Models;
using AspectDemo.Repository;

namespace AspectDemo.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repo;

        public CustomerService(ICustomerRepository repo)
        {
            this.repo = repo;
        }
        public int AddCustomer(Customer customer)
        {
            if (repo.GetCustomer(customer.CustomerId) != null)
            {
                throw new CustomerAlreadyExistsException($"Customer with customer id {customer.CustomerId} already exists");
            }
            return repo.AddCustomer(customer);
        }

        public int DeleteCustomer(int id)
        {
            if (repo.GetCustomer(id) == null)
            {

                throw new CustomerNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.DeleteCustomer(id);
        }

        public Customer GetCustomer(int id)
        {
            Customer c = repo.GetCustomer(id);
            if (c == null)
            {
                throw new CustomerNotFoundException($"Customer with customer id {id} does not exists");
            }
            return c;
        }

        public List<Customer> GetCustomers()
        {
            return repo.GetCustomers();
        }

        public int UpdateCustomer(int id, Customer customer)
        {
            if (repo.GetCustomer(id) == null)
            {
                throw new CustomerNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.UpdateCustomer(id, customer);
        }
    }
}
