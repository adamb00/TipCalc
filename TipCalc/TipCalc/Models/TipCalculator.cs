using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Models
{
    public class TipCalculator
    {

        private double price;


        public TipCalculator(double price)
        {
            this.price = price;

        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double Tip
        {
            get { return price * 0.10; }
        }

        public override string ToString()
        {
            string result = "A számla végösszege: " + price + "\n";
            result += "Elvárt borravaló: " + Tip + "\n";
            result += "A számla 10% borravalóval " + (price + Tip);
            return result.ToString();
        }


    }
}