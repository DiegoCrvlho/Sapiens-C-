namespace Sapiens.Shared.Entities;
public class Funcionario : Pessoa { 
    public decimal Salario { get; set;}
    public string? Cargo { get; set;}
    public int? CargaHoraria { get; set;}
}

