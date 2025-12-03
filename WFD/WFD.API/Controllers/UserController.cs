using Microsoft.AspNetCore.Mvc;
using WFD.Logic;
using WFD.Model.BaseModel;
using WFD.Repository;

namespace WFD.API.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private UserLogic _userLogic;

        public UserController(WFDContext context)
        {
            _userLogic = new UserLogic(context);
        }

        [HttpPost("AddUser")]
        public void AddUser(User user)
        {
            _userLogic.AddUser(user);
        }

        [HttpGet("LogIn")]
        public bool LogIn(string login, string password)
        {
            return _userLogic.LogIn(login, password);
        }

        [HttpPost("AddFavoriteDish")]
        public void AddFavoriteDish(int id, Dish dish)
        {
            _userLogic.AddFavoriteDish(id, dish);
        }

        [HttpDelete("DeletFavoriteDish")]
        public void DeletFavoriteDish(int id, Dish dish)
        {
            _userLogic.DeletFavoriteDish(id, dish);
        }


    }
}
