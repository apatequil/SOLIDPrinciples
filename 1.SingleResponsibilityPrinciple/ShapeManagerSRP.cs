using System;
using System.Collections.Generic;
using Shared.Shapes;
using Shared.Utilities;

namespace SingleResponsibilityPrinciple
{
    public static class ShapeManagerSRP
    {
        public static Dictionary<string,IShape> CurrentShapes = new Dictionary<string,IShape>(StringComparer.OrdinalIgnoreCase);

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
