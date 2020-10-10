using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace WSNumeros
{
    /// <summary>
    /// Summary description for Calcular
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Calcular : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double Triangulo(double Tbase, double Taltura)
        {
            return (Tbase * Taltura) / 2;
        }

        [WebMethod]
        public double Factorial(double Num) {
            double fact = 1;
            if (Num < 0)
                return -1;
            else
            {
                for (int i = 1; i <= Num; ++i)
                {
                    fact *= i;
                }
                return fact;
            }
        }

        [WebMethod]
        public bool Par(double Num) {
            if (Num % 2 == 0) { return true; }

            return false;
        }
    }
}
