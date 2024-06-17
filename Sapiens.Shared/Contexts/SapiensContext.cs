using Microsoft.EntityFrameworkCore;
using sapiens.shared.Entities;
using Sapiens.Shared.Entities;
namespace Sapiens.Shared.Contexts;

public class SapiensContext : DbContext
{
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Coordenador> Coordenadores { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Matricula> Matriculares { get; set;}

    private string directoryDb;

    public SapiensContext()
    {
        var folder = Environment.SpecialFolder.MyDocuments;
        var path = Environment.GetFolderPath(folder);
        directoryDb = Path.Join(path, "UniSapiens.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={directoryDb}");


}