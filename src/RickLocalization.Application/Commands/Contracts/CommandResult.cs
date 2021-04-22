using Newtonsoft.Json;
using System.Net;

namespace RickLocalization.Application.Commands.Contracts
{
    public class CommandResult<T> : ICommandResult<T>
    {
        [JsonIgnore]
        public HttpStatusCode httpStatusCode { get; init; }

        [JsonIgnore]
        public bool success { get; init; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public T response { get; init; }

        public string message { get; init; }
    }
}
