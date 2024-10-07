using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.models
{
    internal class Operation
    {
        public double sum(double num1, double num2)
        {
            return num1 * num2;
        }
        public double minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double division(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }catch(Exception ex)
            {
                MessageBox.Show("error detectado");
               
            }
            return 0;
        }
        public double power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        public double squareroot(double num1)
        {
            return Math.Sqrt(num1);
        }
        public string exitprogram()
        {
            return "andate treintamilvecestreintaijueputa";
        }
    }
}
