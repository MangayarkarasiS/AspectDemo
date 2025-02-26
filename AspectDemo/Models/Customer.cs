using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspectDemo.Models
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
