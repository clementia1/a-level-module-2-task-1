using System;
using System.IO;

namespace Homework04
{
    internal class Starter
    {
        private Logger _logger = Logger.GetInstance();

        public void Run()
        {
            var actions = new Actions();

            for (int i = 0; i < 100; i++)
            {
                var randomNumber = new Random().Next(0, 3);
                var resultObject = new Result();
                switch (randomNumber)
                {
                    case 0:
                        resultObject = actions.FakeMethod();
                        break;
                    case 1:
                        resultObject = actions.FakeMethodWithWarning();
                        break;
                    case 2:
                        resultObject = actions.FakeMethodWithError();
                        break;
                }

                if (resultObject.Status == false)
                {
                    _logger.WriteMessage($"Action failed by a reason: {resultObject.ErrorMessage}", EventType.Error);
                }

                File.WriteAllText("log.txt", _logger.History);
            }
        }
    }
}
