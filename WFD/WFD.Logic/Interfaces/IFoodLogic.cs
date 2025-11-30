using WFD.Model.Model;

namespace WFD.Logic.Interfaces
{
    public interface IFoodLogic
    {
        List<Dish> GetAllDishes();
        void AddNewDish(Dish dish);
    }
}
