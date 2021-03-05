using System;

namespace SmartSchool.API.V2.DTOs
{
    /// <summary>
    /// Este � o DTO de Aluno para Registrar
    /// </summary>
    public class AlunoRegistrarDTO
    {
        /// <summary>
        /// Identificador e chave do banco de dados
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do Aluno para outros negocios da Instituicao
        /// </summary>
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? Datafim { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}