using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    internal class Truck : Car
    {
        public int Weight { get; set; }

        public Truck()
        {
        }

        public Truck(int weight, decimal speed, double regularPrice, string color) : base(speed, regularPrice, color)
        {
            this.Weight = weight;
        }

        /// <summary>
        /// nếu Weight trên 200 thì giảm 10% còn ko thì giảm 20%
        /// </summary>
        /// <returns></returns>
        public double GetSalePrice()
        {
            if (this.Weight > 2000)
            {
                return base.RegularPrice * 0.9;
            }
            else
            {
                return base.RegularPrice * 0.8;
            }
        }

        public override string? ToString()
        {
            return $"{base.ToString()}, Weight: {this.Weight}, SalePrice: {Math.Round(GetSalePrice(),3)}";
        }
    }
}
