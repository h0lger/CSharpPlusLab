using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlusLab
{
    public class MathTest
    {

        public double MyMethod(double a, double b, int no)
        {
            double z = 0;
			for (int i = 0; i < no; i++)
			{
				z =+  Math.Sqrt((a+b+i) * 3.14);
			}

			return z;						
        }
    }
}
