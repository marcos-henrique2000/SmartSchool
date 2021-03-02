using System;
using System.Collections.Generic;
using SmartSchool.API.Models;

namespace SmartSchool.API.DTOs
{
    public class ProfessorRegistrarDTO
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? Datafim { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}