using TPbank.Entities.DTO;
using TPbank.Entities.Entity;
using TPbank.Entities.ExtensionMethod;
using TPBank.DataAccessLayer;

namespace TPBank.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private readonly ICustomerDataAccesslayer _customerDataAccesslayer;

        public CustomerBusinessLogicLayer(ICustomerDataAccesslayer? customerDAL = null)
        {
            this._customerDataAccesslayer = customerDAL ?? new CustomerDataAccesslayer();
        }

        public List<CustomerDTO>? GetCustomers()
        {
            try
            {
                var result = _customerDataAccesslayer.GetCustomers();
                if (result.Count == 0)
                {

                    return null;
                }
                var customerDTO = result.Select(x => new CustomerDTO()
                {
                    CustomerName = x.CustomerName,
                    Address = x.Address,
                    Landmark = x.Landmark,
                    City = x.City,
                    Country = x.Country,
                    Mobile = x.Mobile,
                    Username = x.Username,
                    Password = x.Password

                }).ToList();

                return customerDTO.ToList();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--> " + ex);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return null;

        }

        public void AddCustomer()
        {
            Customer customer = new Customer();

            customer.CustomerId = Guid.NewGuid();
            do
            {
                try
                {
                    Console.Write("CustomerCode: ");
                    customer.CustomerCode = long.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (customer.CustomerCode == default);

            do
            {
                try
                {
                    Console.Write("CustomerName: ");
                    customer.CustomerName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (customer.CustomerName == default);

            Console.Write("Address: ");
            customer.Address = Console.ReadLine();

            Console.Write("Landmark: ");
            customer.Landmark = Console.ReadLine();

            Console.Write("City: ");
            customer.City = Console.ReadLine();

            Console.Write("Country: ");
            customer.Country = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("Mobile: ");
                    customer.Mobile = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (customer.Mobile == default);


            do
            {
                try
                {
                    Console.Write("Username: ");
                    customer.Username = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (customer.Username == default);

            do
            {
                try
                {
                    Console.Write("Password: ");
                    customer.Password = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (customer.Password == default);

            Guid getCustomerId = _customerDataAccesslayer.AddCustomer(customer);
            if (getCustomerId != Guid.Empty)
            {
                Console.WriteLine("Add successfull!");
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                return _customerDataAccesslayer.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--> " + ex);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return true;
        }

        public bool DeleteCustomer(string user)
        {
            try
            {
                return _customerDataAccesslayer.DeleteCustomer(user);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--> " + ex);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return true;
        }

        public bool CheckUsenamePassword(string username, string password)
        {
            return GetCustomers().FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password)) != default;
        }

        public Response<Customer> GetCustomersByCondition(Func<Customer, bool> value)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {

                response.DataList = _customerDataAccesslayer.GetCustomersByCondition(value);


                if (!response.DataList.Any())
                {

                    response.IsSuccess = false;
                    response.Message = "No customer found";
                }
                else
                {

                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<Customer> IsUserNameExist(string? username)
        {

            Response<Customer> response = new Response<Customer>();

            try
            {

                response.Data = _customerDataAccesslayer.GetCustomers().FirstOrDefault(x => x.Username.Equals(username.Trim()));


                if (response.Data == null)
                {

                    response.IsSuccess = false;
                }
                else
                {

                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }

}
