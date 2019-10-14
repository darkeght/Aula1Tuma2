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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CervejasController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Cervejas
        public IQueryable<Cerveja> GetCervejas()
        {
            return db.Cervejas;
        }

        // GET: api/Cervejas/5
        [ResponseType(typeof(Cerveja))]
        public IHttpActionResult GetCerveja(int id)
        {
            Cerveja cerveja = db.Cervejas.Find(id);
            if (cerveja == null)
            {
                return NotFound();
            }

            return Ok(cerveja);
        }

        // PUT: api/Cervejas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCerveja(int id, Cerveja cerveja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cerveja.Id)
            {
                return BadRequest();
            }

            db.Entry<Cerveja>(cerveja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CervejaExists(id))
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

        // POST: api/Cervejas
        [ResponseType(typeof(Cerveja))]
        public IHttpActionResult PostCerveja(Cerveja cerveja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cervejas.Add(cerveja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cerveja.Id }, cerveja);
        }

        // DELETE: api/Cervejas/5
        [ResponseType(typeof(Cerveja))]
        public IHttpActionResult DeleteCerveja(int id)
        {
            Cerveja cerveja = db.Cervejas.Find(id);
            if (cerveja == null)
            {
                return NotFound();
            }

            db.Cervejas.Remove(cerveja);
            db.SaveChanges();

            return Ok(cerveja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CervejaExists(int id)
        {
            return db.Cervejas.Count(e => e.Id == id) > 0;
        }
    }
}