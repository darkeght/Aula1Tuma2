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
using BancoDeDadosInnerJoinWebApi.Models;

namespace BancoDeDadosInnerJoinWebApi.Controllers
{
    public class MarcasController : ApiController
    {
        private InnerJoinContext db = new InnerJoinContext();

        // GET: api/Marcas
        public IQueryable<Marca> GetMarcas()
        {
            return db.Marcas;
        }

        // GET: api/Marcas/5
        [ResponseType(typeof(Marca))]
        public IHttpActionResult GetMarca(int id)
        {
            Marca marca = db.Marcas.Find(id);
            if (marca == null)
            {
                return NotFound();
            }

            return Ok(marca);
        }

        // PUT: api/Marcas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMarca(int id, Marca marca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marca.Id)
            {
                return BadRequest();
            }

            db.Entry(marca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaExists(id))
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

        // POST: api/Marcas
        [ResponseType(typeof(Marca))]
        public IHttpActionResult PostMarca(Marca marca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Marcas.Add(marca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = marca.Id }, marca);
        }

        // DELETE: api/Marcas/5
        [ResponseType(typeof(Marca))]
        public IHttpActionResult DeleteMarca(int id)
        {
            Marca marca = db.Marcas.Find(id);
            if (marca == null)
            {
                return NotFound();
            }

            db.Marcas.Remove(marca);
            db.SaveChanges();

            return Ok(marca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcaExists(int id)
        {
            return db.Marcas.Count(e => e.Id == id) > 0;
        }
    }
}