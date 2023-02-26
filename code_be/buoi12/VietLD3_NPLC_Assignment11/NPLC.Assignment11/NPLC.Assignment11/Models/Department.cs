namespace NPLC.Assignment11.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public override string? ToString()
        {
            return $"\n\tDepartmentId: {DepartmentId},DepartmentName {DepartmentName}";
        }
    }

}
