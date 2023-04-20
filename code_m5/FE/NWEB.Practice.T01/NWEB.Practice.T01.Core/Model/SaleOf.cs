using System.ComponentModel.DataAnnotations;

namespace NWEB.Practice.T01.Core.Model
{
    public class SaleOf
    {

        public int CategoryId { get; set; }
        public int FlowerId { get; set; }
        [Range(1, 100, ErrorMessage = "Sale off percent must be a number between 1 and 100")]
        public int SaleOffPercent { get; set; }
    }
}
