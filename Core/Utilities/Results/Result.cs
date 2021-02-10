namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //:this(success) ile success parametreli constructor da çalıştırmış oluyor.
        public Result(bool success, string message) : this(success)
        {
            Success = success;
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
