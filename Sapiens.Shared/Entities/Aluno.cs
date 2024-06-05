using Sapiens.Shared.Enums;
namespace Sapiens.Shared.Entities;

public class Aluno : Pessoa {
    public string? Matricula { get; set;}
    public SituacaoAluno SituacaoAluno { get; set;}

}
