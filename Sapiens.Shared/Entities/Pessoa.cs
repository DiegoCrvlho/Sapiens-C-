using Sapiens.Shared.Enums;
using Sapiens.Shared.Models;
namespace Sapiens.Shared.Entities;

public abstract class Pessoa : Entidade {
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Sexo Sexo { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    public CorOuRaca CorOuRaca { get; set;}
    public string? Linkedin { get; set; }
}
