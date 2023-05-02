using AreaShapeLibrary;

Circle circle = new ("Круг_1", 10);

Triangle triangle = new Triangle("Треугольник_1", 2,3,4);

Console.WriteLine($"Площадь круга: {circle.CalculateArea()}, площадь треугольника: {triangle.CalculateArea()}");
Console.WriteLine($"Прямоугольный: {triangle.IsStraightTriangle()}");