
namespace Shapes.DrawableShapes
{
    public interface IDrawableShape2dISP : IDrawableShapeISP
    {
        double Length { get; set; }
        double Height { get; set; }

        double GetArea();
    }
}
