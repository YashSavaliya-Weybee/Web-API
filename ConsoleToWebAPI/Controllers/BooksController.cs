using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(50)}")]
        public string GetById(int id)
        {
            return "Hello " + id;
        }
        [Route("{id:minlength(5):alpha}")]
        public string GetById(string id)
        {
            return "Hello string " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Hello string " + id;
        }
    }
}
