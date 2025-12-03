using Microsoft.AspNetCore.Mvc;
using WFD.Logic;
using WFD.Model.BaseModel;

namespace WFD.API.Controllers
{
    [ApiController]
    [Route("Food")]
    public class FoodLibraryController : ControllerBase 
    {
        private FoodLogic _foodLogic = new FoodLogic();

        [HttpGet("GetAllDishes")]
        public List<Dish> GetAllDishes()
        {
            return _foodLogic.GetAllDishes();
        }

        [HttpPost("AddNewDish")]
        public void AddNewDish(Dish dish)
        {
            _foodLogic.AddNewDish(dish);
        }
    }
}
