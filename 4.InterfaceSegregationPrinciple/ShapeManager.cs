using System.Collections.Generic;

using Shared.Shapes;
using Shared.Utilities;

namespace InterfaceSegregationPrinciple
{
    public static class ShapeManager
    {
        public static Dictionary<string, IShape> CurrentShapes = new Dictionary<string, IShape>();

        public static void AddShape(string shapeName, IShape shape)
        {
            // Responsibility: Manage Shapes
            if(!CurrentShapes.ContainsKey(shapeName))
            {
                CurrentShapes.Add(shapeName, shape);
                return;
            }

            // Log duplicate shape error
            Logger.LogError("duplicate username");
        }
    }
}
