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
        public void length()
        {

            //Coodinates 1
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            Console.WriteLine("Enter value X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y1");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());

            //Coodinates 2
            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of S_One");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S_Two");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_One");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_Two");
            B2 = Convert.ToInt32(Console.ReadLine());

            
            double LengthOfXY = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);
            
            double LengthOfAB = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B1 - B2), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfAB);

        }
    }
}
