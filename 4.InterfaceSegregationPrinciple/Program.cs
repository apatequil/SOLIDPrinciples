
using Shared.DrawableShapes;

namespace InterfaceSegregationPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = new Line();
            var rectangle = new Rectangle();

            #region Fix
            // By splitting the interface into finer-grained interfaces you can avoid violating the principle.
            // - IDrawableShapeISP: Contains a position only, which is usable by all shapes
            // - IDrawableShape2dISP: Contains additional dimension and area functionality
            // - Line can simply implement IDrawableShapeISP whereas a rectangle would implement IDrawableShape2dISP
            // Thus, Line no longer needs to implement functionality that doesn't apply
            #endregion

            #region Notes
            // ISP is broken because the consumer of an interface is required to implement functionality it will never use.
            // Violations:
            // 1. IDrawableShape contains GetArea and Height which don't apply to line. Therefore, Line is required to implement
            //      (even just to thrown an exception) when it will never need them. Additional shapes would exacerbate the issue
            //      when circles, polygons, etc.. also fall into this violation
            #endregion
        }
    }
}
