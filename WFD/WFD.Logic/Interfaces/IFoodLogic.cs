using WFD.Model.BaseModel;

namespace WFD.Logic.Interfaces
{
    public interface IFoodLogic
    {
        List<Dish> GetAllDishes();
        void AddNewDish(Dish dish);
        Dish GetDish(int id);
        void AddNewTag(Tag tag);
        void RemoveTag(int id);
        void RemoveDish(int id);
        void RemoveIngredient(int id);

    }
}
