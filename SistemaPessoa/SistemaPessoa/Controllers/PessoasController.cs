using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SistemaPessoa.Models;

namespace SistemaPessoa.Controllers
{
    public class PessoasController : ApiController
    {
        private PessoaContext db = new PessoaContext();

        // GET: api/Pessoas
        public IQueryable<Pessoa> GetPessoas()
        {
            return db.Pessoas;
        }

        // GET: api/Pessoas/5
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult GetPessoa(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        [HttpGet] // Agora identificamos por meio de uma anotação que o metodo é um get
        [Route("Api/Pessoas/Order")] //Adicionamos um caminho na url para ele chamar nosso metodo
        public IQueryable<Pessoa> PessoasOrderDesc()
        {
            return db.Pessoas.OrderByDescending(x => x.Idade); //ordernamos nossa informação 
        }

        // PUT: api/Pessoas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPessoa(int id, Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            db.Entry(pessoa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pessoas
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult PostPessoa(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pessoas.Add(pessoa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoas/5
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult DeletePessoa(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            db.Pessoas.Remove(pessoa);
            db.SaveChanges();

            return Ok(pessoa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PessoaExists(int id)
        {
            return db.Pessoas.Count(e => e.Id == id) > 0;
        }
    }
}