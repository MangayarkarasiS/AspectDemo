using AspectDemo.Models;

namespace AspectDemo.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(int id, Customer customer);
        int DeleteCustomer(int id);
    }
}
