using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineEqualityCheck
    {
        public static void Equals(double X3, double X4, double Y4, double X5, double X6, double Y5, double Y6, double y6)
        {
            double temp1 = Math.Pow((X4 - X3), 2);
            double temp2 = Math.Pow((Y4 - Y4), 2);
            double length = Math.Sqrt((temp1 + temp2));
            double temp3 = Math.Pow((X6 - X5), 2);
            double temp4 = Math.Pow((Y6 - Y5), 2);
            double length2 = Math.Sqrt((temp3 + temp4));
            Console.WriteLine("Length1.Equals(Length2)");

        }
    }
}
