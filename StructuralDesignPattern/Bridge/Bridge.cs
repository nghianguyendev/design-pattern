namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        public string Name { get; set; }

        public IRenderer IRenderer
        {
            get => default;
            set
            {
            }
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer)
        {
            Name = "Triangle";
            _renderer = renderer;
        }

        public string Draw()
        {
            return _renderer.Draw(Name);
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer)
        {
            Name = "Square";
            this._renderer = renderer;
        }

        public string Draw()
        {
            return _renderer.Draw(Name);
        }
    }

    public interface IRenderer
    {

        string Draw(string a);
    }

    public class VectorRenderer : IRenderer
    {
        public VectorRenderer()
        {
        }

        public string Draw(string t)
        {
            return $"Drawing {t} as lines";
        }
    }

    public class RasterRenderer : IRenderer
    {
        public RasterRenderer()
        {
        }

        public string Draw(string t)
        {
            return $"Drawing {t} as pixels";
        }
    }
}