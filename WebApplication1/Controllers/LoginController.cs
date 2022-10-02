using Microsoft.AspNetCore.Mvc;

namespace QuestionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public static List<User> users = new List<User>()
        {
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "123"
            },
            new User
            {
                Id = 2,
                Username = "admin_2",
                Password = "0000000"
            }

        };
      

        [HttpPost]
        public dynamic Login(User value)
        {
            try
            {
                if (value == null)
                {
                    return BadRequest();
                }
                else
                {
                    var query = users.Where(x => x.Username == value.Username && x.Password == value.Password).ToList();
                    if (query.Count > 0)
                    {
                        return new
                        {
                            code = "200",
                            message = "Login successfully"
                        };
                    }
                    else
                    {
                        return BadRequest();
                    }
                }


            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

    }
}
