namespace Intro_Till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle5 = new Circle(5);
            double area5 = circle5.GetArea();
            double roundValue5 = Math.Round(area5,2);
            Console.WriteLine($"Area of the Circle with the radius value of 5 is: {roundValue5}");

            Circle circle6 = new Circle(6);
            double area6 = circle6.GetArea();
            double roundValue6 = Math.Round(area6, 2);
            Console.WriteLine($"Area of the Circle with the radius value of 5 is: {roundValue6}");

        }

        public class Circle
        {

            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double GetArea()
            {
                return radius * radius * Math.PI;
            }

        }
    }
}
