using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraphQLApp.Services;
using Microsoft.Extensions.Logging;


namespace GraphQLApp.Controllers
{
    public class AuthorsController : ControllerBase
    {
        //[Route("api/[controller]")]
        //[ApiController]

        private readonly BlogService blogService;
        public AuthorsController(BlogService blogService)
        {
            this.blogService = blogService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(blogService.GetAllAuthors());
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            return new ObjectResult(blogService.GetAuthorById(id));
        }
        [HttpGet("{id}/posts")]
        public IActionResult GetPostsByAuthor(int id)
        {
            return new ObjectResult(blogService.GetPostsByAuthor(id));
        }
        [HttpGet("{id}/socials")]
        public IActionResult GetSocialsByAuthor(int id)
        {
            return new ObjectResult(blogService.GetsnsByAuthor(id));
        }
    }
}
