using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpPost]
        public Response Post([FromBody] string authorName)
        {
            return AuthorService.AddAuthor(authorName);
        }
    }
}
