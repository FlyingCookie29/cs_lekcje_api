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

        public FoodLibraryController(WFDContext context)
        {
            _foodLogic = new FoodLogic(context);
        }


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
