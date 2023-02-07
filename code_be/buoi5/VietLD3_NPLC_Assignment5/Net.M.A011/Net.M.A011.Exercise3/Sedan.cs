using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    public class Sedan : Car
    {
        public int Length { get; set; }

        public Sedan()
        {
        }

        public Sedan(int length, decimal speed, double regularPrice, string color) : base(speed, regularPrice, color)
        {
            this.Length = length;
        }

        /// <summary>
        /// nếu độ dài dưới 20 thì giảm 5% còn không thì giảm 10%
        /// </summary>
        /// <returns></returns>
        public double GetSalePrice()
        {
            if (this.Length > 20)
            {
                return base.RegularPrice * 0.95;
            }
            else
            {
                return base.RegularPrice * 0.9;
            }
        }

        public override string? ToString()
        {
            return $"{base.ToString()}, Length: {Length}, SalePrice: {Math.Round(GetSalePrice(), 3)}";
        }
    }
}
