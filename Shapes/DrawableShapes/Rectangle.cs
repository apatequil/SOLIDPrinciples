
namespace Shapes.DrawableShapes
{
    public class Rectangle : IDrawableShape
    {
        public virtual double Length { get; set; }
        public virtual double Height { get; set; }
        public Position Position { get; set; }

        public virtual double GetArea()
        {
            return Length * Height;
        }
    }
}
