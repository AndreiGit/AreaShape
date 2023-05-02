namespace AreaShapeLibrary
{
    public abstract class ShapeBase
    {
        public string Name { get; private set; }

        public ShapeBase(string shapeName)
        {
            Name = shapeName;
        }

        public abstract float CalculateArea();
    }
}