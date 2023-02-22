using TPBank.BusinessLogicLayer;

namespace TPBank.Presentation
{
    public class TPBankManagement
    {
        ICustomerBusinessLogicLayer _customerBusinessLogicLayer;

        public TPBankManagement()
        {
            this._customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
        }

        public void Menu()
        {
            Console.WriteLine("********************** TPBank **********************");
            string username = "";
            string password = "";
            do
            {
                Console.WriteLine("::Login Page::");
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();

                if (!_customerBusinessLogicLayer.CheckUsenamePassword(username, password))
                {
                    Console.WriteLine("Username or password is incorrect. Pls re-input");
                    username = "";
                }

            } while (username.Equals(""));

            do
            {
                Console.WriteLine("\n:::Main menu:::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Get All Existing Customer");
                Console.WriteLine("3. Find Customers");
                Console.WriteLine("4. Update Customers");
                Console.WriteLine("5. Delete Customers");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("******************Add Customer******************\n");
                        _customerBusinessLogicLayer.AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("******************Get All Existing Customer******************\n");
                        GetAll();
                        break;
                    case 3:
                        Console.WriteLine("******************Find Customers******************\n");
                        FindCustomer();
                        break;
                    case 4:
                        Console.WriteLine("******************Update Customers******************\n");
                        UpdateCustomer();
                        break;
                    case 5:
                        Console.WriteLine("******************Delete Customers******************\n");
                        DeleteCustomer();
                        break;
                    case 6:
                        return;
                }
            } while (true);
        }

        private void DeleteCustomer()
        {
            Console.Clear();
            Console.WriteLine("::: Delete Customer :::");
            Console.Write("Enter username you want delete: ");
            string username = Console.ReadLine();
            while (!_customerBusinessLogicLayer.IsUserNameExist(username).IsSuccess)
            {
                Console.WriteLine(_customerBusinessLogicLayer.IsUserNameExist(username).Message);
                Console.Write("Enter username you want update: ");
                username = Console.ReadLine();
            }

            if (_customerBusinessLogicLayer.DeleteCustomer(username))
            {
                Console.WriteLine("Delete succeed:");
            }
            else
            {
                Console.WriteLine("Delete faild:");
            }
        }

        private void UpdateCustomer()
        {
            Console.Clear();
            Console.WriteLine("::: Update Customer :::");

            Console.Write("Enter username you want update: ");
            string username = Console.ReadLine();
            while (!_customerBusinessLogicLayer.IsUserNameExist(username).IsSuccess)
            {
                Console.WriteLine(_customerBusinessLogicLayer.IsUserNameExist(username).Message);
                Console.Write("Enter username you want update: ");
                username = Console.ReadLine();
            }

            var responseGet = _customerBusinessLogicLayer.GetCustomersByCondition(c =>
            {
                return c.Username == username;
            });

            var customer = responseGet.DataList.FirstOrDefault();

            Console.WriteLine("::: Customer Info :::");
            Console.WriteLine(customer.PrintForMat());
            Console.WriteLine("=> Enter information you want to update (Address, Landmark, City, Mobile, Password), if input is null, default not change: ");
            Console.Write("Enter address: ");

            string address = Console.ReadLine();
            if (!string.IsNullOrEmpty(address) && !string.IsNullOrWhiteSpace(address))
            {
                customer.Address = address;
            }

            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            if (!string.IsNullOrEmpty(city) && !string.IsNullOrWhiteSpace(city))
            {
                customer.City = city;
            }

            Console.Write("Enter landmark: ");
            string landmark = Console.ReadLine();
            if (!string.IsNullOrEmpty(landmark) && !string.IsNullOrWhiteSpace(landmark))
            {
                customer.Landmark = landmark;
            }

            Console.Write("Enter country: ");
            string country = Console.ReadLine();
            if (!string.IsNullOrEmpty(country) && !string.IsNullOrWhiteSpace(country))
            {
                customer.Country = country;
            }
            bool change = false;
            do
            {
                change = true;
                try
                {
                    Console.Write("Enter Mobile: ");
                    customer.Mobile = Console.ReadLine();
                    change = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (change);

            do
            {
                change = true;
                try
                {
                    Console.Write("Enter password: ");
                    customer.Password = Console.ReadLine();
                    change = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (change);

            bool response = _customerBusinessLogicLayer.UpdateCustomer(customer);
            if (response)
            {
                Console.WriteLine("Update succeed:");
                Console.WriteLine(customer.PrintForMat());
            }
            else
            {
                Console.WriteLine("Update faild");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public void GetAll()
        {
            var customers = _customerBusinessLogicLayer.GetCustomers();
            customers.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        /// <summary>
        /// Find Customer Menu 1. Find By Usernam 2. Find By Address 3. Find By City 4. Find By Mobile 0. Exit
        /// </summary>
        private void FindCustomer()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("::: Find Customer Menu :::");
                Console.WriteLine("1. Find By Username");
                Console.WriteLine("2. Find By Address");
                Console.WriteLine("3. Find By City");
                Console.WriteLine("4. Find By Mobile");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;

                switch (choice)
                {
                    case 1:
                        FindCustomerBy(choice);
                        break;
                    case 2:
                        FindCustomerBy(choice);
                        break;
                    case 3:
                        FindCustomerBy(choice);
                        break;
                    case 4:
                        FindCustomerBy(choice);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        Thread.Sleep(800);
                        break;
                }
            } while (choice != 0);
        }

        /// <summary>
        /// FindCustomerBy sp function FindCustomer by choice
        /// </summary>
        /// <param name="choice"></param>
        private void FindCustomerBy(int choice)
        {
            Console.Clear();
            Console.WriteLine("::: Find Customer :::");
            Console.Write("Enter value: ");
            string input = Console.ReadLine();
            var response = _customerBusinessLogicLayer.GetCustomersByCondition(c =>
            {
                switch (choice)
                {
                    case 1:
                        return c.CustomerName == input;
                    case 2:
                        return c.Address.Contains(input);
                    case 3:
                        return c.City.Contains(input);
                    case 4:
                        return c.Mobile == input;
                    default:
                        return false;
                }
            });
            if (response.IsSuccess)
            {
                Console.WriteLine("Found {0} customer(s)", response.DataList.Count);
                Console.WriteLine(string.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}",
              "CustomerName", "Address", "City", "Country", "Landmark", "Mobile", "Username", "Password"));
                foreach (var customer in response.DataList)
                {
                    Console.WriteLine(customer.ToString());
                }
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
