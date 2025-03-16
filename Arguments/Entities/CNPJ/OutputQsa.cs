using Newtonsoft.Json;

namespace Arguments.Entities.CNPJ;

public class OutputQsa
{
    [JsonProperty("identificador_de_socio")] public int PartnerIdentifier { get; set; }
    [JsonProperty("nome_socio")] public string? PartnerName { get; set; }
    [JsonProperty("cnpj_cpf_do_socio")] public string? PartnerCnpjCpf { get; set; }
    [JsonProperty("codigo_qualificacao_socio")] public int PartnerQualificationCode { get; set; }
    [JsonProperty("percentual_capital_social")] public int SocialCapitalPercentage { get; set; }
    [JsonProperty("data_entrada_sociedade")] public string? SocietyEntryDate { get; set; }
    [JsonProperty("cpf_representante_legal")] public object? LegalRepresentativeCpf { get; set; }
    [JsonProperty("nome_representante_legal")] public object? LegalRepresentativeName { get; set; }
    [JsonProperty("codigo_qualificacao_representante_legal")] public object? LegalRepresentativeQualificationCode { get; set; }
}
