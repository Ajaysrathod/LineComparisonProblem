using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class ComparisonBetweenLine
    {
        public static void CompareOfLine(double X7, double X8, double X9, double X10, double Y7, double Y8, double Y9, double Y10)
        {
            double temp1 = Math.Pow((X8 - X7), 2);
            double temp2 = Math.Pow((Y8 - Y7), 2);
            double LengthOfFirstLine = Math.Sqrt(temp1 + temp2);
            double temp3 = Math.Pow((X10 - X9), 2);
            double temp4 = Math.Pow((Y10 - Y9), 2);
            double LengthOfSecondLine = Math.Sqrt(temp3 + temp4);

            double result = LengthOfFirstLine.CompareTo(LengthOfSecondLine);
            if (result == 0)
            {
                Console.WriteLine("Length of two lines are equal");
            }
            else if (result > 0)
            {
                Console.WriteLine("Length of line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("Length of line1 is less than line2");
            }
        }

    }
}
