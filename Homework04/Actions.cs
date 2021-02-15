namespace Homework04
{
    internal class Actions
    {
        private Logger _logger = Logger.GetInstance();

        public Result FakeMethod()
        {
            var result = new Result { Status = true };
            _logger.WriteMessage($"Start method: {nameof(FakeMethod)}", EventType.Info);
            return result;
        }

        public Result FakeMethodWithWarning()
        {
            var result = new Result { Status = true };
            _logger.WriteMessage($"Skipped logic in method: {nameof(FakeMethodWithWarning)}", EventType.Warning);
            return result;
        }

        public Result FakeMethodWithError()
        {
            var result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            return result;
        }
    }
}
