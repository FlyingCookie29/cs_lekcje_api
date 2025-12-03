using Microsoft.AspNetCore.Mvc;
using WFD.Logic;
using WFD.Model.BaseModel;
using WFD.Repository;

namespace WFD.API.Controllers
{
    [ApiController]
    [Route("Food")]
    public class FoodLibraryController : ControllerBase
    {
        private FoodLogic _foodLogic;

        private Tag _tag;

        public FoodLibraryController(WFDContext context)
        {
            _foodLogic = new FoodLogic(context);
            
        }


        [HttpGet("GetAllDishes")]
        public List<Dish> GetAllDishes()
        {
            return _foodLogic.GetAllDishes();
        }

        [HttpGet("GetDish")]
        public Dish GetDish(int id)
        {
            return _foodLogic.GetDish(id);
        }

        [HttpPost("AddNewDish")]
        public void AddNewDish(Dish dish)
        {
            _foodLogic.AddNewDish(dish);
        }

        [HttpPost("AddNewTag")]
        public void AddNewTag(Tag tag)
        {
            _foodLogic.AddNewTag(tag);
        }

        [HttpDelete("RemoveTag")]
        public void RemoveTag(int id)
        {
            _foodLogic.RemoveTag(id);
        }

        [HttpDelete("RemoveDish")]
        public void RemoveDish(int id)
        {
            _foodLogic.RemoveTag(id);
        }

        [HttpDelete("RemoveIngredient")]
        public void RemoveInGredient(int id)
        {
            _foodLogic.RemoveIngredient(id);
        }
    }
}
