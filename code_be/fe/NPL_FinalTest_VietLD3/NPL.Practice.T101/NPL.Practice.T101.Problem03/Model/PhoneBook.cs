
namespace NPL.Practice.T101.Problem03.Model
{
    public class PhoneBook
    {
        private string phone;
        private string group;

        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.ValidatePhoneNumber())
                {
                    phone = value;
                }
                else
                {
                    throw new Exception("Input value is not correct!");
                }

            }
        }
        public string Group
        {
            get { return group; }
            set
            {
                if (value.ValidateGroup())
                {
                    group = value;
                }
                else
                {
                    throw new Exception("Input value is not correct!");
                }

            }
        }

        public override string? ToString()
        {
            return $"Phone: {Phone}, Group: {Group}, Name: {Name}, Number: {Number}, Email: {Email}, Address: {Address}";
        }


    }
}
