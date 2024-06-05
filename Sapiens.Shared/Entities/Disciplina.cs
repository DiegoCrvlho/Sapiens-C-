﻿using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;
namespace sapiens.shared.Entities;

public class Disciplina
{
    //[StringLength(100)]
    //public required string Nome { get; set; }
    public string? Nome { get; set; }

    public TipoDisciplina Tipo { get; set; }
    public Curso? Curso { get; set; }

    public Professor? Professor { get; set; }
}
