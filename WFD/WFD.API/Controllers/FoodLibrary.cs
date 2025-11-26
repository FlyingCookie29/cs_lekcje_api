using Microsoft.AspNetCore.Mvc;
using WFD.Model.Model;

namespace WFD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodLibraryController : ControllerBase
    {

        public static List<Dish> ddd = new List<Dish>();




        [HttpGet("dishes")]
        public List<Dish> GetDishes()
        {
            #region MyRegion


            Dish d = new Dish();
            d.Id = 8;
            d.Name = "Karbonara";
            d.ExpectedPreparationTime = 30;
            d.Tags = new List<string>();
            d.ExtraNotes = "hjsfoao";
            d.Description = "iufdcguigfe";

            Ingredient i = new Ingredient()
            {
                Name = "jajko",
                Id = 9,
                Quantity = 1,
                MeasurementUnit = "ilość",
                Tags = new List<string>(),
                ExtraNotes = "ouhfasuhf"
            };

            Ingredient i2 = new Ingredient();
            i2.Name = "boczek";
            i2.Id = 10;
            i2.Quantity = 1;
            i2.MeasurementUnit = "ilość";
            i2.Tags = new List<string>();
            i2.ExtraNotes = "ouhfasuhf";

            d.Ingredients = new List<Ingredient>() { i, i2 };

            #endregion

            return ddd;//new List<Dish>() { d };
        }

        [HttpPost("dish")]
        public void AddDishe(Dish dish)
        {
            ddd.Add(dish);
        }

    }
}
