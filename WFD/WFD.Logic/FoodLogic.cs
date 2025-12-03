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

        public void AddNewTag(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        public void RemoveTag(int id)
        {
            var d = _context.Tags.FirstOrDefault(d => d.Id == id);
            if (d != null)
            {
                _context.Tags.Remove(d);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Nie znaleziono Tagu o takim Id.");
            }
        }

        public void RemoveDish(int id)
        {
            var d = _context.Dishes.Include(d => d.Ingredients).FirstOrDefault(d => d.Id == id);
            if (d != null)
            {
                foreach (var item in d.Ingredients)
                {
                    _context.Ingredients.Remove(item);
                }               
                _context.Dishes.Remove(d);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Nie znaleziono dania o takim Id.");
            }
        }

        public void RemoveIngredient(int id)
        {
            var d = _context.Ingredients.FirstOrDefault(d => d.Id == id);
            if (d != null)
            {
                _context.Ingredients.Remove(d);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Nie znaleziono składnika o takim Id.");
            }
        }
    }
}