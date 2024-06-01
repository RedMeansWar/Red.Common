using System;

namespace Red.Common
{
    public class Log
    {
        public static void Info(object message) => CitizenFX.Core.Debug.WriteLine($"{message ?? "null"}");
        public static void Error(object message) => Info($"Error: {message ?? "null"}");
        public static void Error(Exception ex) => Info($"Exception Error: {ex.Message}\n{ex}");
    }
}