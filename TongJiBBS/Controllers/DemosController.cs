﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TongJiBBS.Models;
using System.Collections;
using System.Web.Script.Serialization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TongJiBBS.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        // GET: api/Todo
        [HttpGet]
        public ActionResult Get()
        {
            Demo me = new Demo();
            Hashtable ht = me.get_name();
            JavaScriptSerializer js = new JavaScriptSerializer();
            string strJson = js.Serialize(ht);
            return Json(ht);
        }
    }

    [Route("api/[controller]")]
    public class DemosController : Controller
    {
        // GET: api/Demos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
