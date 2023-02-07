using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    public class Car
    {
        public decimal Speed { get; set; }
        public double RegularPrice { get; set; }
        public string Color { get; set; }

        public Car()
        {
        }

        public Car(decimal speed, double regularPrice, string color)
        {
            this.Speed = speed;
            this.RegularPrice = regularPrice;
            this.Color = color;
        }
        /// <summary>
        /// Trả về giá trị
        /// </summary>
        /// <returns></returns>
        public double GetSalePrice()
        {
            return RegularPrice;
        }

        public override string? ToString()
        {
            return $"Speed: {this.Speed}, RegularPrice: {this.RegularPrice}, Color: {this.Color}";
        }
    }
}
