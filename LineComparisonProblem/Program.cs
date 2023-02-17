namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.WriteLine("1:Distance between line \n2:Line equality check \n3:Comparison Between Line");
            int option = Convert.ToInt32(Console.ReadLine());
            //users switch case to call differnt method
            switch (option)
            {
                case 1:
                    //Taking user input
                    Console.WriteLine("Please enter X1 & Y1 Co-ordinates");
                    var X1 = Convert.ToDouble(Console.ReadLine());
                    var Y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X2 & Y2 Co-ordinates");
                    var X2 = Convert.ToDouble(Console.ReadLine());
                    var Y2 = Convert.ToDouble(Console.ReadLine());
                    var finalResult = DistanceBetweenLine.Distance(X1, X2, Y1, Y2);

                    Console.WriteLine("Distance between co-ordinates {0},{1},{2},{3},{4}", X1, X2, Y1, Y2, finalResult);
                    break;
                case 2:
                    Console.WriteLine("Please enter X3 & Y3 Co-ordinates");
                    var X3 = Convert.ToDouble(Console.ReadLine());
                    var Y3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X4 & Y4 Co-ordinates");
                    var X4 = Convert.ToDouble(Console.ReadLine());
                    var Y4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X5 & Y5 Co-ordinates");
                    var X5 = Convert.ToDouble(Console.ReadLine());
                    var Y5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X6 & Y6 Co-ordinates");
                    var X6 = Convert.ToDouble(Console.ReadLine());
                    var Y6 = Convert.ToDouble(Console.ReadLine());

                    LineEqualityCheck.Equals(X3, Y3, X4, Y4, X5, Y5, X6, Y6);

                    break;
                case 3:
                    Console.WriteLine("Please enter X7 & Y7 Co-ordinates");
                    var X7 = Convert.ToDouble(Console.ReadLine());
                    var Y7 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X8 & Y8 C0-ordinates");
                    var X8 = Convert.ToDouble(Console.ReadLine());
                    var Y8 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X9 & Y9 Co-ordinates");
                    var X9 = Convert.ToDouble(Console.ReadLine());
                    var Y9 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X10 & Y10 Co-ordinates");
                    var X10 = Convert.ToDouble(Console.ReadLine());
                    var Y10 = Convert.ToDouble(Console.ReadLine());
                    ComparisonBetweenLine.CompareOfLine(X7, Y7, X8, Y8, X9, Y9, X10, Y10);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }

        }
        }
    }

