namespace Intro_Till_OOP
{
    internal class Circle
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
