using NPL.Practice.T101.Problem03.Model;
using NPL.Practice.T101.Problem03.Utill;
using System.Numerics;

namespace NPL.Practice.T101.Problem03
{
    public class PhoneBookManagement
    {
        private List<PhoneBook> listPhoneBook;

        public PhoneBookManagement()
        {
            this.listPhoneBook = new List<PhoneBook>()
            {
                new PhoneBook()
                {
                    Phone= "091 234 5678",
                    Group= "Family",
                    Name="Nguyen Van A",
                    Number=1,
                    Address="Ha noi"
                },
                new PhoneBook()
                {
                    Phone= "091 234 5678",
                    Group= "Family",
                    Name="Le Duc A",
                    Number=1,
                    Address="Ha noi"
                },
                new PhoneBook()
                {
                    Phone= "091 234 7777",
                    Group= "Colleague",
                     Name="Le Duc C",
                    Number=3,
                    Address="Ha noi"
                },
                new PhoneBook()
                {
                    Phone= "091 555 5678",
                    Group= "Friend",
                    Name="Le Duc B",
                    Number=2,
                    Address="Ha noi"
                },
            };
        }

        /// <summary>
        /// thêm mới PhoneBook
        /// </summary>
        public void Add()
        {
            PhoneBook phoneBook = new PhoneBook();

            do
            {
                try
                {
                    phoneBook.Phone = Validation.GetStringNotRegex("Input Phone: ", "Input again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (phoneBook.Phone == default);

            do
            {
                try
                {
                    phoneBook.Group = Validation.GetStringNotRegex("Input Group: ", "Input again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (phoneBook.Group == default);

            phoneBook.Number = Validation.GetInt("Input Number: ");
            phoneBook.Address = Validation.GetString("Input Address: ", @"^[a-zA-Z\s]+$", "Input again");
            phoneBook.Email = Validation.GetStringNotRegex("Input Email: ", "Input again");

            listPhoneBook.Add(phoneBook);
        }

        /// <summary>
        /// xóa theo tên
        /// </summary>
        public void Remove()
        {
            string name = Validation.GetString("Input PhoneBook Name: ", @"^[a-zA-Z\s]+$", "Input again");
            //tìm kiếm phone
            PhoneBook phoneBook = listPhoneBook.Find(p => p.Name.Equals(name));
            if (phoneBook != null)
            {
                listPhoneBook.Remove(phoneBook);
                Console.WriteLine("Remove Ok ");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            

        }

        /// <summary>
        /// sắp xếp danh sách theo tên
        /// </summary>
        public void Sort()
        {
            // sắp xếp theo tên
            listPhoneBook.Sort((a, b) => string.Compare(a.Name, b.Name));
        }

        /// <summary>
        /// tìm PhoneBook theo tên
        /// </summary>
        public void Find()
        {
            string name = Validation.GetString("Input PhoneBook Name: ", @"^[a-zA-Z\s]+$", "Input again");

            //tìm kiếm phone
            PhoneBook phoneBook = listPhoneBook.Find(p => p.Name.Equals(name));

            if (phoneBook != null)
            {
                Console.WriteLine("Information: ");
                Console.WriteLine(phoneBook.ToString());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        /// <summary>
        /// in toàn bộ sản phẩm
        /// </summary>
        public void Display()
        {
            foreach (PhoneBook item in listPhoneBook)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
