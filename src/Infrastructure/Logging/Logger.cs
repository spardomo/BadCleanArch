using System;

namespace Infrastructure.Logging { 
    public static class Logger
    {
        private static bool _enabled = true;
        public static bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }

        public static void Log(string message)
        {
            if (!Enabled) return;
            Console.WriteLine("[LOG] " + DateTime.Now + " - " + message);
        }

        public static void Try(Action a)
        {
            try 
            { 
                a(); 
            } 
            catch(Exception ex) 
            {
                Console.Error.WriteLine("[Logger.Try] " + ex);
            }
        }
    }
}