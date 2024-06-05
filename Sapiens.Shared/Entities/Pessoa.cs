using Sapiens.Shared.Enums;
using Sapiens.Shared.Models;
namespace Sapiens.Shared.Entities;

public abstract class Pessoa {
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Foto { get; set; }
    public Endereco? Endereco { get; set; }
    public Sexo Sexo { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    public CorOuRaca CorOuRaca { get; set;}
    public string? TipoSanguineo { get; set; }
    public string? Instagram { get; set; }
    public string? X {  get; set; }
    public string? TikTok {  get; set; }
}
