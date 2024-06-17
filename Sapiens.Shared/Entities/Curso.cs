using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;
namespace sapiens.shared.Entities;

public class Curso : Entidade {
    public string? Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    public Coordenador? Coordenador { get; set; }
    //public SapiensContext Context { get; internal set; }

    public override string ToString()
    {
        return Nome ?? "";
    }

    public List<Disciplina> Disciplinas { get; } = new();
}
