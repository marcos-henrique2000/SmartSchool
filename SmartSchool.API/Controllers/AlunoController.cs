using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;
        public AlunoController(IRepository repo) 
        {
            _repo = repo;
        }

        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(result);
        }

        // GET api/<AlunoController>/5
        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            var aluno = _repo.GetAllAlunoById(id, false);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if(_repo.SaveChanges()) return Ok("Aluno cadastrado");
            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunoById(id);
            if (alu == null) return BadRequest("Alunos não encontrado");

            _repo.Update(aluno);
            if(_repo.SaveChanges()) return Ok("Aluno atualizado");
            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunoById(id);
            if (alu == null) return BadRequest("Alunos não encontrado");

            _repo.Update(aluno);
            if(_repo.SaveChanges()) return Ok("Aluno atualizado");
            return BadRequest("Aluno não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alu = _repo.GetAllAlunoById(id);
            if (alu == null) return BadRequest("Alunos não encontrado");
            _repo.Delete(alu);
            if(_repo.SaveChanges()) return Ok("Aluno Deleteado");
            return BadRequest("Aluno não deletado");
        }
    }
}
