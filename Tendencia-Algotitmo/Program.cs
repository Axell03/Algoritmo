using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tendencia_Algotitmo
{
    internal class Program
    {
        private static string ConvertToRoman(int number)
        {
            if(number <= 0 || number >= 4000)
            {
                throw new ArgumentException("EL número fuera del rango 1 al 3999 no es valido");
            }

            string[] rangoNumber = { "M", "D", "C", "L", "X", "V", "I" };
            int[] value = { 1000, 500, 100, 50, 10, 5, 1 };

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                while (number >= value[i])
                {
                    if (i < rangoNumber.Length)
                    {
                        sb.Append(rangoNumber[i]);

                    }
                }

            }
            return sb.ToString();
        }


    }
}
