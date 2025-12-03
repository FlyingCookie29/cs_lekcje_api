using WFD.Model.BaseModel;

namespace WFD.Logic.Interfaces
{
    public interface IFoodLogic
    {
        List<Dish> GetAllDishes();
        void AddNewDish(Dish dish);
    }
}
