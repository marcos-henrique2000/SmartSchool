using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;
        public Repository(SmartContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public Aluno[] GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if(includeProfessor){
                query = query.Include(a => a.AlunoDisciplinas)
                                     .ThenInclude(ad => ad.Disciplina)
                                     .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking().OrderBy(a => a.Id);
            return query.ToArray();
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if(includeProfessor){
                query = query.Include(a => a.AlunoDisciplinas)
                                     .ThenInclude(ad => ad.Disciplina)
                                     .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking()
                            .OrderBy(a => a.Id)
                            .Where(alunos => alunos.AlunoDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));
            return query.ToArray();
        }

        public Aluno GetAllAlunoById(int alunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if(includeProfessor){
                query = query.Include(a => a.AlunoDisciplinas)
                                     .ThenInclude(ad => ad.Disciplina)
                                     .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking()
                            .OrderBy(a => a.Id)
                            .Where(alunos => alunos.Id == alunoId);
            return query.FirstOrDefault();
        }

        public Professor[] GetAllProfessores( bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;
            
            if(includeAlunos){
                query = query.Include(p => p.Disciplina)
                                    .ThenInclude(d => d.AlunoDisciplina)
                                    .ThenInclude(a => a.Aluno); 
            }

            query = query.AsNoTracking().OrderBy(a => a.Id);
            return query.ToArray();
        }

        public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if(includeAlunos){
                query = query.Include(p => p.Disciplina)
                             .ThenInclude(d => d.AlunoDisciplina)
                             .ThenInclude(a => a.Aluno); 
            }

            query = query.AsNoTracking()
                         .OrderBy(aluno => aluno.Id)
                         .Where(aluno => aluno.Disciplina.Any(
                                d => d.AlunoDisciplina.Any(ad => ad.DisciplinaId == disciplinaId)
                         ));
                                
            return query.ToArray(); 
        }

        public Professor GetAllProfessorById(int professorId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if(includeAlunos){
                query = query.Include(p => p.Disciplina)
                             .ThenInclude(d => d.AlunoDisciplina)
                             .ThenInclude(a => a.Aluno); 
            }

            query = query.AsNoTracking().OrderBy(a => a.Id)
                                .Where(professores => professores.Id == professorId);
            return query.FirstOrDefault();
        }

    }
}