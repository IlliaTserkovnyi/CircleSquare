using System;

namespace CircleSquare
{
    public class Program
    {
        public static void Main()
        {
            do 
            {
                Console.Clear();
                CircleFigure circle;
                SquareFigure square;
                Console.WriteLine("Please, input radius of the circle:");
                double radiusCircle = DigitMaker.GetValidValue();
                ShowStrip();
                Console.WriteLine("Please, input side of the square:");
                double sideSquare = DigitMaker.GetValidValue();
                ShowStrip();

                circle = new CircleFigure(Math.Round(radiusCircle, 2));
                square = new SquareFigure(Math.Round(sideSquare, 2));
                circle.Show();
                Console.WriteLine("Circle Area is: {0}", circle.Area);
                square.Show();
                Console.WriteLine("Square Area is: {0}", square.Area);
                ShowStrip();

                IsSquareFitCircle(circle.Radius, square.Side);
                ShowStrip();

                Console.WriteLine("Continue? 1 - Yes");
            } while (Console.ReadLine() == "1");
        }
        private static void ShowStrip()
        {
            Console.WriteLine("-----------");
        }

        private static void IsSquareFitCircle(double radius, double side)
        {
            Console.WriteLine("Square Fit Circle? -"+(radius >= side / Math.Sqrt(2) ? "Yes" : "No"));
            Console.WriteLine("Does Circle Fit Square? -" + (radius <= side / 2 ? "Yes" : "No"));
        }

        //private static void IsCircleFitSquare(double radius, double side)
        //{
        //    Console.WriteLine("Does Circle Fit Square? -" + (radius <=side/2 ? "Yes" : "No"));
        //}
    }

}
