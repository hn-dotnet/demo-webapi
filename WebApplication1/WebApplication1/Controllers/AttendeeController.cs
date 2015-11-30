using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AttendeeController : ApiController
    {
        public DB db { get; set; }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            
            this.db = new DB();
        }

        // GET api/<controller>
        public IEnumerable<AttendeeModel> Get()
        {
            //return this.db.Attendees.ToList

            return new List<AttendeeModel>()
            {
                new AttendeeModel() { Id = Guid.NewGuid(), Email = "jonathan.guenz@outlook.com", Name = "Jonathan Günz"  }
            };
        }

        // GET api/<controller>/5
        public AttendeeModel Get(Guid id)
        {
            return this.db.Attendees.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}