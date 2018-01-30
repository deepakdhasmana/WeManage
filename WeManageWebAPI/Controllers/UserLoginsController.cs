﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WeManageWebAPI.Models;

namespace WeManageWebAPI.Controllers
{
    public class UserLoginsController : ApiController
    {
        private DBModelContainer db = new DBModelContainer();

        // GET: api/UserLogins
        public IQueryable<UserLogin> GetUserLogins()
        {
            return db.UserLogins;
        }

        // GET: api/UserLogins/5
        [ResponseType(typeof(UserLogin))]
        public IHttpActionResult GetUserLogin(int id)
        {
            UserLogin userLogin = db.UserLogins.Find(id);
            if (userLogin == null)
            {
                return NotFound();
            }

            return Ok(userLogin);
        }

        // GET: api/UserLogins/5
        [HttpGet]
        [ResponseType(typeof(UserLogin))]
        public IHttpActionResult AuthenticateUser([FromUri]int id, [FromUri] string UserID, [FromUri] string Password)
        {
            var record = db.UserLogins.Where(x => x.UserID == UserID).FirstOrDefault();
            if (record == null)
            {
                return NotFound();
            }
            if (record.Password == Password)
            {
                return Ok(record);
            }
            return NotFound();
        }

        // PUT: api/UserLogins/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserLogin(int id, UserLogin userLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userLogin.UserLoginID)
            {
                return BadRequest();
            }

            db.Entry(userLogin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserLoginExists(id))
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

        // POST: api/UserLogins
        [ResponseType(typeof(UserLogin))]
        public IHttpActionResult PostUserLogin(UserLogin userLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserLogins.Add(userLogin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = userLogin.UserLoginID }, userLogin);
        }

        // DELETE: api/UserLogins/5
        [ResponseType(typeof(UserLogin))]
        public IHttpActionResult DeleteUserLogin(int id)
        {
            UserLogin userLogin = db.UserLogins.Find(id);
            if (userLogin == null)
            {
                return NotFound();
            }

            db.UserLogins.Remove(userLogin);
            db.SaveChanges();

            return Ok(userLogin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserLoginExists(int id)
        {
            return db.UserLogins.Count(e => e.UserLoginID == id) > 0;
        }
    }
}