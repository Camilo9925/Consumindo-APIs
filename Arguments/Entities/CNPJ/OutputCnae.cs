using Newtonsoft.Json;

namespace Arguments.Entities.CNPJ;

public class OutputCnae
{
    [JsonProperty("codigo")] public int Code { get; set; }
    [JsonProperty("descricao")] public string? Description { get; set; }
}
