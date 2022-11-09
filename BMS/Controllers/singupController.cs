using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BMS.Models;
using Microsoft.AspNetCore.Http;

namespace BMS
{
    public class singupController : Controller
    {
        private readonly ILogger<singupController> _logger;
        public singupController(ILogger<singupController> logger)
        {
            _logger = logger;
        }
        public IActionResult SignUp()
        {
            ViewData["Message"]="Login";  
            return View();
        }
        [HttpPost("singup/CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody]Login UserDetails)
        {
            string userEmailId = string.Empty;
            string password = string.Empty;
            try
            {
                userEmailId =UserDetails.UserEmailId;
                password = UserDetails.Password;
                if(string.IsNullOrEmpty(userEmailId))
                {
                    return new JsonResult(new {massage="Userr email id is null."})
                    {
                        StatusCode=StatusCodes.Status400BadRequest
                    };
                }
                var crDate = System.DateTime.Now.ToString("dd-MM-yyyy");
                bool userExistsInSystem =await BMS.Models.DataAccessModel.CheckUserExists(userEmailId); 
                if(!userExistsInSystem)
                {
                    var objCreateUser = new Login(userEmailId,password,crDate,false,false,false,false);
                    var userCreate = await BMS.Models.DataAccessModel.createNewUser(objCreateUser);
                    if(userCreate)
                    {
                        return new JsonResult(new { message = "User Created." })
                        {
                            StatusCode = StatusCodes.Status200OK // Status code here 
                        };
                    }
                    else
                    {
                        return new JsonResult(new { message = "User Not created" })
                        {
                        StatusCode = StatusCodes.Status400BadRequest // Status code here 
                        };
                    }
                }
                else
                {
                    return new JsonResult(new {massage="User exsts into system."})
                    {
                        StatusCode=StatusCodes.Status400BadRequest
                    };
                }
                
                
            }
            catch(System.Exception)
            {
                //Response.StatusCode=StatusCodes.Status400BadRequest;
                return new JsonResult(new { message = "User Not created" })
                {
                    StatusCode = StatusCodes.Status400BadRequest // Status code here 
                };
            }
            //return RedirectToRoute(new { controller = "Login", action = "Login" });
        }
    }
}