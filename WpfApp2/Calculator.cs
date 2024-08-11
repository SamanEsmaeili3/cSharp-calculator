using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Calculator
    {
        public string add(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            n1 += n2;
            return n1.ToString();
        }

        public string minus(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            n1 -= n2;
            return n1.ToString();
        }

        public string multiply(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            n1 *= n2;
            return n1.ToString();
        }

        public string divide(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            n1 /= n2;
            return n1.ToString();
        }
    }
}
