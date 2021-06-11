namespace LifeWithoutBridge
{
    public abstract class Shape
    {
        public string Name { get; set; }
    }

    public class Triangle : Shape
    {
        public Triangle()
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square()
        {
            Name = "Square";
        }
    }

    public class TriangleVectorRenderer : Triangle
    {
        public string Draw()
        {
            return $"Drawing {Name} as lines";
        }
    }

    public class SquareVectorRenderer : Square
    {
        public string Draw()
        {
            return $"Drawing {Name} as lines";
        }
    }

    public class TriangleRasterRenderer : Triangle
    {
        public string Draw()
        {
            return $"Drawing {Name} as lines";
        }
    }

    public class SquareRasterRenderer : Square
    {
        public string Draw()
        {
            return $"Drawing {Name} as lines";
        }
    }
}