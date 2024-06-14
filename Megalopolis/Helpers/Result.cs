using System.Net;

namespace Megalopolis.Helpers
{
    public class Result<T>
    {
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; } = Array.Empty<string>();

        public Result<T> AppendData(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            Data = data;
            StatusCode = statusCode;
            return this;
        }

        public Result<T> AppendError(string error, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Errors = Errors.Append(error);
            return this;
        }

        public void AddErrors(string errors)
        {
            Errors = Errors.Append(errors);
        }
    }

    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((double)TotalItems / PageSize);
            }
        }
    }
}
