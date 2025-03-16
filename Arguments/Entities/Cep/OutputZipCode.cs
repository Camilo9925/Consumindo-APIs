using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Arguments.Entities.Cep;

public class OutputZipCode
{
    [JsonProperty("cep")] public string? Cep { get; set; }
    [JsonProperty("state")] public string? State { get; set; }
    [JsonPropertyName("city")] public string? City { get; set; }
    [JsonProperty("neighborhood")] public string? Neighborhood { get; set; }
    [JsonProperty("street")] public string? Street { get; set; }
    [JsonProperty("service")] public string? Service { get; set; }
}
