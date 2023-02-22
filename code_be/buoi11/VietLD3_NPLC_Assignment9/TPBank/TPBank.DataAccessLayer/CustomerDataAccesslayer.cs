using TPbank.Entities.ExtensionMethod;

namespace TPBank.DataAccessLayer
{
    public class CustomerDataAccesslayer : ICustomerDataAccesslayer
    {
        private readonly List<Customer> _customers;

        public CustomerDataAccesslayer()
        {
            _customers = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = Guid.NewGuid(),  CustomerCode = 1, CustomerName = "Nguyen Van A",
                    Address = "Thach That", City = "Ha Noi", Country = "Viet Nam", Landmark = "VAca",
                    Username = "anv1", Password = "Viet1112"
                },
                new Customer()
                {
                    CustomerId = Guid.NewGuid(),  CustomerCode = 2, CustomerName = "Nguyen Van B",
                    Address = "Thach That", City = "Ha Noi", Country = "Viet Nam", Landmark = "Vaca2",
                    Username = "xnv5", Password = "Viet1112"
                },
                new Customer()
                {
                    CustomerId = Guid.NewGuid(),  CustomerCode = 2, CustomerName = "Nguyen Van C",
                    Address = "Thach That", City = "Ha Noi", Country = "Viet Nam", Landmark = "Vaca3",
                    Username = "system", Password = "manager"
                }
            };
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate)
        {
            return _customers.Where(predicate).ToList();
        }

        public Guid AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            return customer.CustomerId;
        }

        public bool UpdateCustomer(Customer customer)
        {

            var customerIndex = _customers.FindIndex(c => c.Username == customer.Username);
            if (customerIndex == null)
            {
                return false;
            }
            if (customerIndex >= 0)
            {
                _customers[customerIndex] = customer;
                return true;
            }

            return false;
        }

        public bool DeleteCustomer(string name)
        {
            var customer = _customers.FirstOrDefault(x => x.Username.Equals(name));
            if (customer == null) { return false; }
            _customers.Remove(customer);
            return true;
        }


    }
}
