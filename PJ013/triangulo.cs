using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ013
{
    internal class triangulo
    {
        //atributos
        private double a;
        private double b;
        private double c;




        //metodos 
        public void setVa(double p)
        {
            a = p;
        }

        public void setVb(double p)
        {
            b = p;
        }

        public void setVc(double p)
        {
            c = p;
        }

        public double getVa()
        {
            return a;
        }

        public double getVb()
        {
            return b;
        }

        public double getVc()
        {
            return c;
        }


        public string calcularValores()


        {
            if (a * a == c * c + b * b || b * b == c * c + a * a || c * c == a * a + b * b)
                return " Valores formam um triângulo retângulo";

            else

                return "valores não formam um triângulo retângulo";
        }
    }


}

