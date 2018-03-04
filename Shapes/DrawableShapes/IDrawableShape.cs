
namespace Shapes.DrawableShapes
{
    public interface IDrawableShape
    {
        Position Position { get; set; }
        double Length { get; set; }
        double Height { get; set; }

        double GetArea();
    }
}
