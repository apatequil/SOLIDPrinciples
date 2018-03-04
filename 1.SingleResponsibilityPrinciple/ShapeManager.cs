using System;
using System.Collections.Generic;

using Shared.Shapes;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public static class ShapeManager
    {
        public static Dictionary<string,IShape> CurrentShapes = new Dictionary<string,IShape>(StringComparer.OrdinalIgnoreCase);

        private static readonly string _logPath = @"c:\log.txt";

        public static void AddShape(string shapeName, IShape shape)
        {
            // Add shape if it doesn't exist
            if(!CurrentShapes.ContainsKey(shapeName))
            {
                CurrentShapes.Add(shapeName, shape);
                return;
            }

            // Log error due to duplicate shape
            if (!File.Exists(_logPath))
            {
                File.Create(_logPath);
            }

            using (TextWriter writer = new StreamWriter(File.Open(_logPath, FileMode.Append)))
            {
                writer.WriteLine("duplicate shape");
            }
        }

        #region Notes
        // Responsibility: Manage Shapes
        // Responsibility: Maintain log path
        // Responsibility: Create log file if necessary
        // Responsibility: Log the error
        #endregion
    }
}
