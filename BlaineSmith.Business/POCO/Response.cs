
namespace BlaineSmith.Business.POCO
{
    public class Response
    {
        public ResponseType Success { get; set; }
        public string Message { get; set; }
    }

    public enum ResponseType
    {
        Error,
        Success
    }
}
