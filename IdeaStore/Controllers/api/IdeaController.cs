using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdeaStore.Business.Dto;
using IdeaStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaStore.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeaController : ControllerBase
    {
        // GET: api/Idea
        [HttpGet]
        public OperationResult<List<IdeaData>> GetAll()
        {
            return new OperationResult<List<IdeaData>>() { Data = new List<IdeaData>()
            {
               new IdeaData() { Description = "Test1", Name = "Test2", Id = 1},
               new IdeaData() { Description = "Test2", Name = "Test3", Id = 1}
            }};
        }
//
//        // GET: api/Idea/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }
//
//        // POST: api/Idea
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }
//
//        // PUT: api/Idea/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }
//
//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
    }
}
