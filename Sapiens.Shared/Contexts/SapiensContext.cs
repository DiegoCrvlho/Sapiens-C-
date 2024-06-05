using sapiens.shared.Entities;
using Sapiens.Shared.Entities;
namespace Sapiens.Shared.Contexts;

public class SapiensContext
{
    public List<Curso> Cursos { get; set; }
    public List<Disciplina> Disciplinas { get; set; }
    public List<Funcionario> Funcionarios { get; set; }
    public List<Coordenador> Coordenadores { get; set; }
    public List<Aluno> Alunos { get; set; }
    public List<Professor> Professores { get; set; }

    public SapiensContext()
    {
        Cursos = new();
        Disciplinas = new();
        Funcionarios = new();
        Coordenadores = new();
        Funcionarios = new();
        Professores = new();
    }

    public void AdicionaCurso(Curso curso)
    {
        curso.Context = this;
        Cursos.Add(curso);
    }
}