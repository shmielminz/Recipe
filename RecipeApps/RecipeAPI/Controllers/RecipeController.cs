using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }

        [HttpGet("{id:int:min(1)}")]
        public bizRecipe GetById(int id)
        {
            bizRecipe r = new();
            r.Load(id);
            return r;
        }

        [HttpGet("getbycookbook/{cookbookname}")]
        public List<bizRecipe> GetByCookbook(string cookbookname)
        {
            return new bizRecipe().GetRecipesFromCookbook(cookbookname);
        }

        [HttpGet("getbycuisine/{cuisinetype}")]
        public List<bizRecipe> GetByCuisine(string cuisinetype)
        {
            return new bizRecipe().GetRecipesByCuisine(cuisinetype);
        }

        [HttpPost]
        public IActionResult Post([FromForm] bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new { message = $"Recipe {recipe.RecipeName} was successfuly saved", recipeid = recipe.RecipeId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            bizRecipe recipe = new();
            try
            {
                recipe.Delete(id);
                return Ok(new { message = "Recipe Deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("staff")]
        public List<bizStaff> GetStaff()
        {
            return new bizStaff().GetList();
        }
    }
}
