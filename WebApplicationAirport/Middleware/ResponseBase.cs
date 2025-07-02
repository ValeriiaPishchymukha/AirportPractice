namespace WebApplicationAirport.Middleware
{
    public class ResponseBase<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public T Data { get; set; }

        public ResponseBase(int statusCode, string message, string status, T data = default!)
        {
            StatusCode = statusCode;
            Message = message;
            Status = status;
            Data = data;
        }
    }
}
