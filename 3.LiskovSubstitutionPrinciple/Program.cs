using System;

using Shared.Shapes;

namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeManager.AddShape("Rectangle", new Rectangle { Length = 50, Height = 10 });
            ShapeManager.AddShape("Square", new Square { Length = 50, Height = 10 });
            ShapeManager.AddShape("Rectangle substituted with Square", new Square { Length = 50, Height = 10 } as Rectangle);

            foreach(var shape in ShapeManager.CurrentShapes)
            {
                Console.WriteLine($"{shape.Key}: {shape.Value.GetArea()}");
            }


            Console.ReadLine();

            #region Outputs
            // Outputs:
            // 500: Rectangle
            // 100: Square
            // 100: Rectangle substituted with Square <-- Broken! Square should be able to be subbed in without different results
            #endregion

            #region Fix
            ShapeManager.CurrentShapes.Clear();
            ShapeManager.AddShape("Rectangle", new RectangleLSP { Length = 50, Height = 10 });
            ShapeManager.AddShape("Square", new SquareLSP { Length = 50 });

            // Compile error: Square no longer subtypes rectangle and therefore can't be subbed in disallowing violations
            //ShapeManager.AddShape("Rectangle substituted with Square", new SquareLSP { Length = 50, Height = 10 } as RectangleLSP);

            //foreach (var shape in manager.CurrentShapes)
            //{
            //    Console.WriteLine($"{shape.Key}: {shape.Value.GetArea()}");
            //}

            #endregion

            #region Notes
            // LSP is broken because the derived type (Square) introduces side effects/differences
            // when used as a Rectangle. There are actually 3 violations:
            // 1. The width property of Square also sets the height, something rectangle doesn't do
            // 2. The hieght property of Square also sets the width, something the rectangle doesn't do
            // 3. The Area calculation squares the common backing property in the derived class rather than
            //    multiplying width and height
            #endregion
        }
    }
}
