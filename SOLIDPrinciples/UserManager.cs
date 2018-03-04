using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BasicImplementation
{
    public static class UserManager
    {
        public static List<string> Users = new List<string>();

        public static void AddUser(string username)
        {
            // Responsibility 1: User list management
            if(!Users.Contains(username, StringComparer.OrdinalIgnoreCase))
            {
                Users.Add(username);
                return;
            }

            // Responsibility 2: Logging an error
            var _logFile = "c:\\logs\\log.txt";

            if (!File.Exists(_logFile))
            {
                File.Create(_logFile);
            }

            using (TextWriter writer = new StreamWriter(_logFile, true))
            {
                writer.WriteLine($"{username} already exists");
            }

            /*
             Basic implementation is nice and small but tightly couples the logging domain with
             the user management domain.

             Per SRP, a class should have one and only one reason to change. In this case there
             are two: 
                1. If the user management requiements change
                2. If the logging requirements change
            */
        }
    }
}
