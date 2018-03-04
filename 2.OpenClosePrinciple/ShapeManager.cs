using System.Collections.Generic;

using Shared.Shapes;
using Shared.Utilities;
using Shared.Utilities.Loggers;

namespace OpenClosePrinciple
{
    public static class ShapeManager
    {
        public static Dictionary<string,IShape> CurrentShapes = new Dictionary<string,IShape>();

        public static void AddShape(string shapeName, IShape shape)
        {
            // Responsibility: Manage Shapes
            if(!CurrentShapes.ContainsKey(shapeName))
            {
                CurrentShapes.Add(shapeName, shape);
                return;
            }
            
            LoggerOCP.log = new DbLogger();

            // Log duplicate shape error
            LoggerOCP.LogError("duplicate username");

            #region Notes
            // Switch to Shared.Utilities.Logger.cs to view violation
            #endregion
        }
    }
}
