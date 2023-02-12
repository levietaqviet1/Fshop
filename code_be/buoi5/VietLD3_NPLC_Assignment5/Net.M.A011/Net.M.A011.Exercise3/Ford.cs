using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    internal class Ford : Car
    {
        public int Year { get; set; }
        public int ManufacturerDiscount { get; set; }

        public Ford()
        {
        }

        public Ford(int year, int manufacturerDiscount, decimal speed, double regularPrice, string color) : 
            base(speed, regularPrice, color)
        {
            this.Year = year;
            this.ManufacturerDiscount = manufacturerDiscount;
        }

        /// <summary>
        /// Giá bằng RegularPrice - ManufacturerDiscount
        /// </summary>
        /// <returns></returns>
        public override double GetSalePrice()
        {
            return base.RegularPrice - this.ManufacturerDiscount;
        }
        public override string? ToString()
        {
            return $"{base.ToString()}, Year: {Year}, ManufacturerDiscount: {ManufacturerDiscount}, SalePrice: {Math.Round(GetSalePrice(), 3)}";
        }

    }
}
