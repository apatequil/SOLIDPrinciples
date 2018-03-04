
namespace Shared.Shapes
{
    public class SquareLSP : IShape
    {
        public virtual double Length { get; set; }

        public double GetArea()
        {
            return Length * Length;
        }
    }
}
