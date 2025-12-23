using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFD.API.Controllers;
using WFD.Logic.Interfaces;
using WFD.Model.BaseModel;
using Moq;

namespace WFD.Logic.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void FoodController_ShouldReturn_CorrectData()
        {
            //Arrange - zaranrzuj/przygotuj/zaplanuj
            var foodLogicMock = new Mock<IFoodLogic>();

            List<Dish> dishes = new List<Dish>();
            Dish dish = new Dish()
            {
                Id = 0,
                Name = "Spagetti",
                ExpectedPreparationTime = 30,
                Ingredients = new List<Ingredient>(),
                Tags = new List<Tag>(),
                ExtraNotes = "",
                Description = ""
            };
            dishes.Add(dish);

            foodLogicMock
                .Setup(c => c.GetAllDishes())
                .Returns(dishes);

            var controller = new FoodLibraryController(foodLogicMock.Object);


            //Act - działaj/wykonaj

            var result = controller.GetAllDishes();

            //Assert - porównaj

            Assert.Equal(dishes, result);
        }
    }

}
