using System;

namespace CircleSquare
{
    public class SquareFigure
    {
        public double Side { get; set; }
        public double Area => Math.Round(Side * Side, 2);
        public SquareFigure(double side)
        {
            Side = side;
        }

        public void Show()
        {
            Console.WriteLine("Square Parameters: {0}",Side);
        }
    }
}
