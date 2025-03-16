using Newtonsoft.Json;

namespace Arguments.Entities.CNPJ;

public class OutputCnpj
{
    [JsonProperty("cnpj")] public string? Cnpj { get; set; }
    [JsonProperty("identificador_matriz_filial")] public int BranchHeadquartersIdentifier { get; set; }
    [JsonProperty("descricao_matriz_filial")] public string? BranchHeadquartersDescription { get; set; }
    [JsonProperty("razao_social")] public string? CorporateName { get; set; }
    [JsonProperty("nome_fantasia")] public string? TradeName { get; set; }
    [JsonProperty("situacao_cadastral")] public int RegistrationStatus { get; set; }
    [JsonProperty("descricao_situacao_cadastral")] public string? RegistrationStatusDescription { get; set; }
    [JsonProperty("data_situacao_cadastral")] public string? RegistrationStatusDate { get; set; }
    [JsonProperty("motivo_situacao_cadastral")] public int RegistrationStatusReason { get; set; }
    [JsonProperty("nome_cidade_exterior")] public object? ForeignCityName { get; set; }
    [JsonProperty("codigo_natureza_juridica")] public int LegalNatureCode { get; set; }
    [JsonProperty("data_inicio_atividade")] public string? ActivityStartDate { get; set; }
    [JsonProperty("cnae_fiscal")] public int MainCnae { get; set; }
    [JsonProperty("cnae_fiscal_descricao")] public string? MainCnaeDescriptio { get; set; }
    [JsonProperty("descricao_tipo_de_logradouro")] public string? StreetTypeDescription { get; set; }
    [JsonProperty("logradouro")] public string? Street { get; set; }
    [JsonProperty("numero")] public string? Number { get; set; }
    [JsonProperty("complemento")] public string? AdditionalInfo { get; set; }
    [JsonProperty("bairro")] public string? Neighborhood { get; set; }
    [JsonProperty("cep")] public int PostalCode { get; set; }
    [JsonProperty("uf")] public string? State { get; set; }
    [JsonProperty("codigo_municipio")] public int CityCode { get; set; }
    [JsonProperty("municipio")] public string? City { get; set; }
    [JsonProperty("ddd_telefone_1")] public string? PhoneDdd1 { get; set; }
    [JsonProperty("ddd_telefone_2")] public object? PhoneDdd2 { get; set; }
    [JsonProperty("ddd_fax")] public object? FaxDdd { get; set; }
    [JsonProperty("qualificacao_do_responsavel")] public int ResponsibleQualification { get; set; }
    [JsonProperty("capital_social")] public int SocialCapital { get; set; }
    [JsonProperty("porte")] public int CompanySize { get; set; }
    [JsonProperty("descricao_porte")] public string? CompanySizeDescription { get; set; }
    [JsonProperty("opcao_pelo_simples")] public bool OptedForSimples { get; set; }
    [JsonProperty("data_opcao_pelo_simples")] public object? SimplesOptionDate { get; set; }
    [JsonProperty("data_exclusao_do_simples")] public object? SimplesExclusionDate { get; set; }
    [JsonProperty("opcao_pelo_mei")] public bool OptedForMei { get; set; }
    [JsonProperty("situacao_especial")] public object? SpecialStatus { get; set; }
    [JsonProperty("data_situacao_especial")] public object? SpecialStatusDate { get; set; }
    [JsonProperty("cnaes_secundarios")] public List<OutputCnae>? SecondaryCnaes { get; set; }
    [JsonProperty("qsa")] public List<OutputQsa>? Qsa { get; set; }
}
