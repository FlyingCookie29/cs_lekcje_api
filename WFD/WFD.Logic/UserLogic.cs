using System.Linq;
using WFD.Model.BaseModel;
using WFD.Repository;

namespace WFD.Logic

{
    public class UserLogic
    {
        private WFDContext _context;
        public UserLogic(WFDContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            var User = _context.Users.FirstOrDefault(u => u.Login == user.Login);
            if (User == null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Taki urzytkownik już istnieje");
            }
        }

        public bool LogIn(string login, string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddFavoriteDish(int id, Dish dish)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                user.FavoriteDishes.Add(dish);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Nie ma takiego użytkownika");
            }
        }

        public void DeletFavoriteDish(int id, Dish dish)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                user.FavoriteDishes.Remove(dish);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Nie ma takiego użytkownika");
            }
        }

    }
}
