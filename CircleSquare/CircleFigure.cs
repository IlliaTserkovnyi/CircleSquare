using System;

namespace CircleSquare
{
    public class CircleFigure
    {
        public double Radius { get; set; }
        public double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        public CircleFigure(double radius)
        {
            Radius = radius;
        }

        public void Show()
        {
            Console.WriteLine("Circle Parameters: {0}",Radius);
        }
    }
}
