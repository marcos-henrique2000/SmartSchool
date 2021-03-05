using System;

namespace SmartSchool.API.V2.DTOs
{
 
    public class AlunoDTO
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
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public DateTime DataIni { get; set; }
        public bool Ativo { get; set; }
    }
}