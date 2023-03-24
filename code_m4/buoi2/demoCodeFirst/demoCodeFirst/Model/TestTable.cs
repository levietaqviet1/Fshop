using Microsoft.EntityFrameworkCore;

namespace demoCodeFirst.Model
{
    [PrimaryKey("State", "LicensePlate")]
    public class TestTable
    {
        public string State { get; set; }
        public string LicensePlate { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
