using sapiens.shared.Entities;
using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

var coordenador = new Coordenador();
var context = new SapiensContext();

coordenador.Nome = "Allan dos Santos";
coordenador.Cpf = "1234567";
coordenador.Endereco = new() {
    Uf = "Porto Velho",
    Municipio = "Porto Velho"
};

// CURSO 1
var curso = new Curso();
curso.Nome = "Sistemas de Informação";
curso.CargaHoraria = 3200;
curso.Tipo = TipoCurso.Bacharelado;
curso.Coordenador = coordenador;
context.AdicionaCurso(curso);

// CURSO 2
var curso2 = new Curso();
curso2.Nome = "Engenharia de Software";
curso2.CargaHoraria = 2700;
curso2.Tipo = TipoCurso.Especializacao;
curso2.Coordenador = coordenador;
context.AdicionaCurso(curso2);

foreach (var items in context.Cursos)
{
    Console.WriteLine($"Curso: {items.Nome}");
}

var professor = new Professor();
professor.Nome = "Liluyoud";
professor.Titulacao = Titulacao.PhD;

var disciplina = new Disciplina();
disciplina.Nome = "Programação Orientada a Objetos";
disciplina.Curso = curso;
disciplina.Tipo = TipoDisciplina.Presencial;
disciplina.Professor = professor;


//Console.WriteLine($"Curso :          {curso.Nome}" );
//Console.WriteLine($"Coordenador:     {curso.Coordenador.Nome}");
//Console.WriteLine($"Cidade:          {curso.Coordenador.Endereco.Municipio}");
//Console.WriteLine($"Disciplina:      {disciplina.Curso.Nome}");
//Console.WriteLine($"Tipo disciplina: {disciplina.Tipo}");
//Console.WriteLine($"Professor:       {disciplina.Professor.Nome}");
//Console.WriteLine($"Titulação:       {professor.Titulacao}");
