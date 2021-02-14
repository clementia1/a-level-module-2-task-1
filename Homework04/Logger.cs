using System;
using System.Text;

namespace Homework04
{
    internal class Logger
    {
        private static Logger _instance;

        private StringBuilder _history = new StringBuilder();

        private Logger()
        {
        }

        public string History
        {
            get
            {
                return _history.ToString();
            }

            set
            {
                _history.Append(value);
            }
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void WriteMessage(string message, EventType type)
        {
            var timeStamp = DateTime.UtcNow;
            var consoleMessage = $"{timeStamp}: {type}: {message}";
            Console.WriteLine(consoleMessage);

            History = $"{consoleMessage} {Environment.NewLine}";
        }
    }
}
