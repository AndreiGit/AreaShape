namespace AreaShapeLibrary
{
    public class Triangle : ShapeBase
    {
        public float SideA { get; private set; }

        public float SideB { get; private set; }

        public float SideC { get; private set; }

        public Triangle(string shapeName, float a, float b, float c) : base(shapeName)
        {
            if (IsTriangleExist(a,b,c))
            {
                SideA = a; 
                SideB = b; 
                SideC = c;
            }
        }

        public override double CalculateArea()
        {
            return Math.Round(CalculateByHeronMethod(), 2);
        }

        public bool IsStraightTriangle()
        {
            bool isStraight = SideA == CalculateSideInStraightTriangle(SideB, SideC)
                               || SideB == CalculateSideInStraightTriangle(SideA, SideC)
                               || SideC == CalculateSideInStraightTriangle(SideA, SideB);

            return isStraight;
        }

        private bool IsTriangleExist(float a, float b, float c)
        {
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleException("Ошибка создания треугольника : одна из сторон больше суммы двух других");
            }

            return true;
        }

        private double CalculateByHeronMethod()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;
            var square = Math.Sqrt(
                halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC)
                );
            return square;
        }

        private double CalculateSideInStraightTriangle(float sideA, float sideB)
        {
           return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
    }
}
