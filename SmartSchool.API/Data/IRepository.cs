using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         bool SaveChanges();

        // Alunos
        public Aluno[] GetAllAlunos(bool includeProfessor);
        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        public Aluno GetAllAlunoById(int alunoId, bool includeProfessor = false);

        // Professores
        public Professor[] GetAllProfessores( bool includeAlunos = false);
        public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);
        public Professor GetAllProfessorById(int professorId, bool includeAlunos = false);
    }
}