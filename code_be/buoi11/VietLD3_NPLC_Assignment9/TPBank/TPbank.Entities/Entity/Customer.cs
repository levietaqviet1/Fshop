namespace TPbank.Entities.ExtensionMethod
{
    public class Customer
    {
        private Guid customerId;

        public Guid CustomerId
        {
            get { return customerId; }
            set
            {
                if (!value.IsValidCustomerId())
                {
                    throw new Exception("CustomerId is null");
                }
                customerId = value;
            }
        }

        private long customerCode;

        public long CustomerCode
        {
            get { return customerCode; }
            set
            {
                if (!value.IsValidCustomerCode())
                {
                    throw new Exception("CustomerCode < 0");
                }
                customerCode = value;
            }
        }

        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (!value.IsValidCustomerName())
                {
                    throw new Exception("CustomerName is null or more than 40 characters");
                }
                customerName = value;
            }
        }

        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set
            {
                if (!value.IsValidMobile())
                {
                    throw new Exception("Mobile is not 10-digit number");
                }
                mobile = value;
            }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                if (!value.IsValidUsername())
                {
                    throw new Exception("Username is null");
                }
                username = value;
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (!username.Equals("system") && !value.Equals("manager") && !value.IsValidPassword())
                {
                    throw new Exception("Password is not 6 characters or " +
                        "sinclude lower case, upper case, and digit number");
                }
                password = value;
            }
        }

        public Customer()
        {
        }

        public Customer(long customerCode, string customerName, string address, string landmark, string city, string country, string mobile, string username, string password)
        {
            CustomerId = Guid.NewGuid();
            CustomerCode = customerCode;
            CustomerName = customerName;
            Address = address;
            Landmark = landmark;
            City = city;
            Country = country;
            Mobile = mobile;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {

            return string.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}",
              CustomerName, Address, City, Country, Landmark, Mobile, Username, Password);
        }

        public string PrintForMat()
        {

            return $"CustomerName: {CustomerName}\nAddress: {Address}\nLandmark:{Landmark}\nCity:{City}\nCountry:{Country}\nMobile:{Mobile}\nUsername:{Username}\nPassword:{Password}\n";
        }
    }
}
