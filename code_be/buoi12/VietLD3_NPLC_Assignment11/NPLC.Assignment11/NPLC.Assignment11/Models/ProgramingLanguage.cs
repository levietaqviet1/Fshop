namespace NPLC.Assignment11.Models
{
    public class ProgramingLanguage
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public ProgramingLanguage()
        {
            Employees = new HashSet<Employee>();
        }
    }
}