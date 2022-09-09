using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Values1Controller : ControllerBase
    {
        //[Route("get-all")]
        [Route("~/getall")]
        public string GetAll()
        {
            return "Hello from Get All";
        }
        //[Route("get-all-authors")]
        //[Route("getall")] this is not possible
        public string GetAllAuthors()
        {
            return "Hello from Get All Authors";
        }

        //[Route("book/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello " + id;
        }

        //[Route("book/{id}/{AuthorId}")]
        public string GetAuthorAddressById(int id, int AuthorId)
        {
            return "Hello " + id + " " + AuthorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int AuthorId, string name, int rating, int price)
        {
            return "Hello " + id + " " + AuthorId;
        }
    }
}
