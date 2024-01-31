using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetList();
        }

        [HttpGet("{id:int:min(1)}")]
        public bizCookbook GetById(int id)
        {
            bizCookbook c = new();
            c.Load(id);
            return c;
        }
    }
}
