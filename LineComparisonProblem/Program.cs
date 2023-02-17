namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.WriteLine("1:Distance between line \n2:Line equality check \n3:Comparison between line");
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
            }
        }
    }
}
