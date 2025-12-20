using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFD.Model.BaseModel
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public List<Dish>? FavoriteDishes { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
    }
}
