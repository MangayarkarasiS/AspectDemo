using AspectDemo.Models;

namespace AspectDemo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext db;

        public CustomerRepository(DataContext db)
        {
            this.db = db;
        }
        public int AddCustomer(Customer customer)
        {
            db.Customers1.Add(customer);
            return db.SaveChanges();
        }

    

        public int DeleteCustomer(int id)
        {
            Customer c = db.Customers1.Where(x => x.CustomerId == id).FirstOrDefault();
            db.Customers1.Remove(c);
            return db.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers1.Where(x => x.CustomerId == id).FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return db.Customers1.ToList();



        }

        public int UpdateCustomer(int id, Customer customer)
        {
            Customer c = db.Customers1.Where(x => x.CustomerId == id).FirstOrDefault();
            c.Name = customer.Name;
            c.Email = customer.Email;
            c.Age = customer.Age;
            c.City = customer.City;
            db.Entry<Customer>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }

       

     
    }
}

