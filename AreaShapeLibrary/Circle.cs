namespace AreaShapeLibrary
{
    public class Circle : ShapeBase
    {
        public float Radius { get; private set; }

        public Circle(string shapeName, float radius) : base(shapeName)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
