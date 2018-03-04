using System;

namespace Shapes.DrawableShapes
{
    public class Line : IDrawableShape
    { 
        public double Length { get; set; }
        public Position Position { get; set; }

        public double Height
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
