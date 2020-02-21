using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uravnenie
{
    public class Diskriminanta
    {
        public double D(double a,double b,double c)
        {
            var result = b * b - 4 * a * c;
            if (result<0)
            {
                throw new InvalidOperationException("Уравнението няма реални корени");
            }
            return result;
        }
       
    }
}
