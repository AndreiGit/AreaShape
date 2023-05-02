using AreaShapeLibrary;

Circle circle = new ("Круг_1", 5);

Triangle triangle = new Triangle("Треугольник_1", 5,3,3);

Console.WriteLine($"Площадь круга: {circle.CalculateArea()}, площадь треугольника: {triangle.CalculateArea()}");
Console.WriteLine($"Прямоугольный: {triangle.IsStraightTriangle()}");