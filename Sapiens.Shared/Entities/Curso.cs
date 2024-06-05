using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;
namespace sapiens.shared.Entities;

public class Curso {
    public string? Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    //public Curso(string nome)
    //{
    //    Nome = nome;
    //}

    public Coordenador? Coordenador { get; set; }
    public SapiensContext Context { get; internal set; }

    public override string ToString()
    {
        return Nome ?? "";
    }
}
