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
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PlaylistsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Playlists
        public IQueryable<Playlist> GetPlaylists()
        {
            return db.Playlists;
        }

        // GET: api/Playlists/5
        [ResponseType(typeof(Playlist))]
        public IHttpActionResult GetPlaylist(int id)
        {
            Playlist playlist = db.Playlists.Find(id);
            if (playlist == null)
            {
                return NotFound();
            }

            return Ok(playlist);
        }

        // PUT: api/Playlists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlaylist(int id, Playlist playlist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != playlist.Id)
            {
                return BadRequest();
            }

            db.Entry(playlist).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaylistExists(id))
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

        // POST: api/Playlists
        [ResponseType(typeof(Playlist))]
        public IHttpActionResult PostPlaylist(Playlist playlist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Playlists.Add(playlist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = playlist.Id }, playlist);
        }

        // DELETE: api/Playlists/5
        [ResponseType(typeof(Playlist))]
        public IHttpActionResult DeletePlaylist(int id)
        {
            Playlist playlist = db.Playlists.Find(id);
            if (playlist == null)
            {
                return NotFound();
            }

            db.Playlists.Remove(playlist);
            db.SaveChanges();

            return Ok(playlist);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlaylistExists(int id)
        {
            return db.Playlists.Count(e => e.Id == id) > 0;
        }
    }
}