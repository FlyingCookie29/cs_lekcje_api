using Microsoft.EntityFrameworkCore;
using WFD.Logic.Interfaces;
using WFD.Model.BaseModel;
using WFD.Repository;

namespace WFD.Logic
{
    public class FoodLogic : IFoodLogic
    {
        private WFDContext _context;

        public FoodLogic(WFDContext c)
        {
            _context = c;
        }

        public List<Dish> GetAllDishes()
        {
            return _context.Dishes.ToList();
        }

        public Dish GetDish(int id)
        {
            return _context.Dishes.Include(dish => dish.Ingredients).FirstOrDefault(d => d.Id == id);
        }

        public void AddNewDish(Dish dish)
        {
            _context.Dishes.Add(dish);
            _context.SaveChanges();
        }
    }
}