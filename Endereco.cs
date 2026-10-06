using System.Text.Json.Serialization;

namespace ConsumerViaCep.Models;

public class Endereco
{
    [JsonPropertyName("cep")]
    public string? Cep { get; set; }

    [JsonPropertyName("logradouro")]
    public string? Logradouro { get; set; }

    [JsonPropertyName("localidade")]
    public string? Localidade { get; set; }
    
    // Você pode adicionar as outras propriedades do JSON aqui, como bairro, uf, ddd, etc.
}