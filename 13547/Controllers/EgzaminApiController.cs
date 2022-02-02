using _13547.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _13547.Controllers
{
    [Route("api/egzams")]
    [ApiController]
    public class EgzaminApiController : ControllerBase
    {

        // GET api/<EgzaminApiController>/5
        [HttpGet("{id}")]
        public ActionResult<Egzamin> Get(int id)
        {
            if (id<5&&id>0)
            {
                return new OkObjectResult(new Egzamin() {Id=id, Note = "C", Date = DateTime.Parse("2022-02-02") });
            }
            else
            {
                return new NotFoundResult();
            }
        }

        // POST api/<EgzaminApiController>
        [HttpPost]
        public ActionResult<Egzamin> Post([FromBody] Egzamin egzamin)
        {
            egzamin.Id = 2;
            return new CreatedResult($"/api/egzams/{egzamin.Id}", egzamin);
        }
    }
}
