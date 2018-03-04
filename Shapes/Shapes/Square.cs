
namespace Shapes.Shapes
{
    public class Square : Rectangle
    {
        private double _edgeSize;
        public override double Length
        {
            get { return _edgeSize; }
            set { _edgeSize = value; }
        }

        public override double Height
        {
            get { return _edgeSize; }
            set { _edgeSize = value; }
        }

        public override double GetArea()
        {
            return _edgeSize * _edgeSize;
        }
    }
}
