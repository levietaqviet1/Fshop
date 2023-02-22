using TPbank.Entities.ExtensionMethod;

namespace TPbank.Entities.DTO
{
    public class CustomerDTO
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public CustomerDTO()
        {

        }

        public CustomerDTO(Customer customer)
        {
            CustomerName = customer.CustomerName;
            Address = customer.Address;
            City = customer.City;
            Country = customer.Country;
            Landmark = customer.Landmark;
            Mobile = customer.Mobile;
            Username = customer.Username;
            Password = customer.Password;
        }

        public override string ToString()
        {
            return string.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}",
              CustomerName, Address, City, Country, Landmark, Mobile, Username, Password);
        }
    }
}
