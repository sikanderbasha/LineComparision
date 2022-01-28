using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class LineComparision
    {
        public int X1;
        public int X2;
        public int Y1;
        public int Y2;
        public int A1;
        public int A2;
        public int B1;
        public int B2;
        public double LengthOfXY;
        public double LengthOfAB;
        public void length()
        {

           
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            Console.WriteLine("Enter value X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y1");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of A1");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of A2");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale B1");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale B2");
            B2 = Convert.ToInt32(Console.ReadLine());


            double LengthOfXY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);

          


            double LengthOfAB = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfAB);

            


            bool Result = LengthOfXY.Equals(LengthOfAB);

            if (Result == false)
            {
                Console.WriteLine("Lines LengthOfXY and LengthOfSR are NOT Equal.");
            }
            else
            {
                Console.WriteLine("Lines LengthOfXY and LengthOfSR are Equal.");
            }
          

            double Differene = LengthOfXY.CompareTo(LengthOfAB);
            if (Differene < 0)
            {
                Console.WriteLine("Length of Line LengthOfXY is less than LengthOfAB.");
            }
            if (Differene > 0)
            {
                Console.WriteLine("Length of Line LengthOfXY is greater than LengthOfAB.");
            }
            if (Differene == 0)
            {
                Console.WriteLine("Both Lines are equal in Length.");
            }
            Console.ReadKey();

        }
    }
}
