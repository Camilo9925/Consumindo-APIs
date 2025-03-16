using Newtonsoft.Json;

namespace Arguments.Entities.DDD;

public class OutputDdd
{
    [JsonProperty("state")] public string? State { get; set; }
    [JsonProperty("cities")] public List<string>? Cities { get; set; }
}
