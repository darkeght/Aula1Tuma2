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
using RegistroImoveis.Models;

namespace RegistroImoveis.Controllers
{
    public class ImovelsController : ApiController
    {
        private RegistroContext db = new RegistroContext();

        // GET: api/Imovels
        public IQueryable<Imovel> GetImovels()
        {
            return db.Imovels;
        }

        // GET: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult GetImovel(int id)
        {
            Imovel imovel = db.Imovels.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            return Ok(imovel);
        }

        // PUT: api/Imovels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImovel(int id, Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imovel.Id)
            {
                return BadRequest();
            }

            db.Entry(imovel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
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

        // POST: api/Imovels
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult PostImovel(Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imovels.Add(imovel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imovel.Id }, imovel);
        }

        // DELETE: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult DeleteImovel(int id)
        {
            Imovel imovel = db.Imovels.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            db.Imovels.Remove(imovel);
            db.SaveChanges();

            return Ok(imovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImovelExists(int id)
        {
            return db.Imovels.Count(e => e.Id == id) > 0;
        }
    }
}