namespace Architecture.Application.Common.Results
{
    public class Result
    {
        public bool Success { get; protected set; }

        public string Message { get; protected set; } = string.Empty;

        public IEnumerable<string>? Errors { get; protected set; }

        public static Result Succeeded(string message = "")
        {
            return new Result
            {
                Success = true,
                Message = message
            };
        }

        public static Result Failure(
            string message,
            IEnumerable<string>? errors = null)
        {
            return new Result
            {
                Success = false,
                Message = message,
                Errors = errors
            };
        }
    }
    public class Result<T> : Result
    {
        public T? Data { get; private set; }

        public static Result<T> Succeeded(
            T data,
            string message = "")
        {
            return new Result<T>
            {
                Success = true,
                Data = data,
                Message = message
            };
        }

        public static new Result<T> Failure(
            string message,
            IEnumerable<string>? errors = null)
        {
            return new Result<T>
            {
                Success = false,
                Message = message,
                Errors = errors
            };
        }
    }
}