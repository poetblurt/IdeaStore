using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdeaStore.Business.Features.Ideas;
using IdeaStore.Business.Infrastructure;
using IdeaStore.Models;
using IdeaStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaStore.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeaController : ControllerBase
    {
       private readonly IBusinessActionLocator _actionLocator;

       public IdeaController(IBusinessActionLocator actionLocator)
       {
          _actionLocator = actionLocator;
       }

        // GET: api/Idea
        [HttpGet]
        public OperationResult<List<IdeaData>> GetAll()
        {
           var action = _actionLocator.GetAction<GetIdeasAction>();
           return action.Execute();
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
