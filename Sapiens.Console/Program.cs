using Microsoft.EntityFrameworkCore;
using sapiens.shared.Entities;
using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

var context = new SapiensContext();
context.Database.Migrate();

var curso = new Curso();
curso.Nome = "Sistemas de Informação";
curso.CargaHoraria = 3200;

var lilo = new Professor();
lilo.Nome = "Lilo Carvalho";
lilo.Cpf = "111.111.111-11";


var alan = new Coordenador() {
    Nome = "Alan Ferreira",
    Cpf = "222.222.222-22"
};

curso.Coordenador = alan;
context.Add(curso);
context.Add(lilo);
context.Add(alan);
