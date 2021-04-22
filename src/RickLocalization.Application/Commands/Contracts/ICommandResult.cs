using System.Net;

namespace RickLocalization.Application.Commands.Contracts
{
    public interface ICommandResult<T>
    {
        public HttpStatusCode httpStatusCode { get; init; }
        public bool success { get; init; }
        public string message { get; init; }
        public T response { get; init; }
    }
}
