namespace Sapiens.Shared.Models;

public record Endereco {
    public string? Rua { get; set; }
    public int Numero { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Municipio { get; set; }
    public string? Uf {  get; set; }
}
