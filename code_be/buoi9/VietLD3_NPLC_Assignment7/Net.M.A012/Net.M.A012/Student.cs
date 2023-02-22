namespace Net.M.A012.Exercise1
{
    internal class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime EntryDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        private decimal mark;

        public decimal Mark
        {
            get { return mark; }
            set
            {
                mark = value;
                if (value >= 85)
                {
                    Graduate(4);
                }
                else if (value >= 80)
                {
                    Graduate(3.7);
                }
                else if (value >= 75)
                {
                    Graduate(3.3);
                }
                else if (value >= 70)
                {
                    Graduate(3);
                }
                else if (value >= 65)
                {
                    Graduate(2.7);
                }
                else if (value >= 60)
                {
                    Graduate(2.3);
                }
                else if (value >= 55)
                {
                    Graduate(2);
                }
                else if (value >= 50)
                {
                    Graduate(1);
                }
                else
                {
                    Graduate(0);
                }
            }
        }

        public string Grade { get; set; }

        public Student()
        {
        }

        /// <summary>
        ///Relationship giá trị mặc định là Single
        //////EntryDate: the default value is the current date
        ///Mark: default value is 0.
        ///Grade: default value is F
        /// </summary>
        /// <param name="name"></param>
        /// <param name="class"></param>
        /// <param name="gender"></param>
        /// <param name="relationship"></param>
        /// <param name="entryDate"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <param name="mark"></param>
        /// <param name="grade"></param>
        public Student(string name, string @class, string gender, string relationship = "Single",
            DateTime? entryDate = null, int age = 0, string address = "", decimal mark = 0, string grade = "F")
        {
            Name = name;
            Class = @class;
            Gender = gender;
            Relationship = relationship;
            EntryDate = entryDate ?? DateTime.Today; ;
            Age = age;
            Address = address;
            Mark = mark;
            Grade = grade;
        }
        public override string? ToString()
        {
            return $"Name: {Name}, Class: {Class}, Gender: {Gender}, Relationship: {Relationship}, EntryDate: {EntryDate}, Age: {Age}, Address: {Address}, Mark: {Mark}, Grade: {Grade}";
        }
        public void Graduate(double gradePoint = 0)
        {
            switch (gradePoint)
            {

                case 0:
                    Grade = "F (Fail)";
                    break;
                case 1:
                    Grade = "D";
                    break;
                case 2:
                    Grade = "C";
                    break;
                case 2.3:
                    Grade = "C+";
                    break;
                case 2.7:
                    Grade = "B-";
                    break;
                case 3.0:
                    Grade = "B";
                    break;
                case 3.3:
                    Grade = "B+";
                    break;
                case 3.7:
                    Grade = "A-";
                    break;
                case 4:
                    Grade = "A";
                    break;
            }
        }


    }
}
