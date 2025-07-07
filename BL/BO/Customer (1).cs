using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName {  get; set; }
        public string Address {  get; set; }
        public string Phone {  get; set; }

        public Customer(int id, string customerName, string address, string phone)
        {
            Id = id;
            CustomerName = customerName;
            Address = address;
            Phone = phone;
        }
    }
}
