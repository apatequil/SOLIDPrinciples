﻿
namespace Shapes.Shapes
{
    public class RectangleLSP : IShape
    {
        public virtual double Length { get; set; }
        public virtual double Height { get; set; }
        
        public virtual double GetArea()
        {
            return Length * Height;
        }
    }
}
