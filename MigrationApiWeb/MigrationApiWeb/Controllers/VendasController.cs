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
using MigrationApiWeb.Models;

namespace MigrationApiWeb.Controllers
{
    public class VendasController : ApiController
    {
        private MigrationContext db = new MigrationContext();

        // GET: api/Vendas
        public IQueryable<Vendas> GetVendas()
        {
            return db.Vendas;
        }

        // GET: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult GetVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            return Ok(vendas);
        }

        // PUT: api/Vendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVendas(int id, Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendas.Id)
            {
                return BadRequest();
            }

            db.Entry(vendas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendasExists(id))
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

        // POST: api/Vendas
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult PostVendas(Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendas.Add(vendas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vendas.Id }, vendas);
        }

        // DELETE: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult DeleteVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            db.Vendas.Remove(vendas);
            db.SaveChanges();

            return Ok(vendas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendasExists(int id)
        {
            return db.Vendas.Count(e => e.Id == id) > 0;
        }
    }
}