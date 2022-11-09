using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BMS.Models;
using Microsoft.AspNetCore.Http;

namespace BMS
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            ViewData["Message"]="Login";  
            return View();
        }
        [HttpGet]
        public ActionResult GetPasswordSHAFormate(string password)
        {
            return Content(BMS.Models.DataAccessModel.GetHashString(password));
        }
        [HttpGet]
        public async Task<IActionResult> LoginProcess(string userEmailId,string password)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(userEmailId) || string.IsNullOrWhiteSpace(password))
                {
                    return new JsonResult(new { message = "UserName and password not allow null or empty." })
                    {
                    StatusCode = StatusCodes.Status400BadRequest // Status code here 
                    };    
                }
                BMS.Models.Login loginData = await BMS.Models.DataAccessModel.SingInProcess(userEmailId,password);
                if(loginData == null)
                {
                    return new JsonResult(new { message = "Usesr not found.." })
                    {
                    StatusCode = StatusCodes.Status400BadRequest // Status code here 
                    };
                }
                else
                {
                    return new JsonResult(loginData)
                    {
                        StatusCode = StatusCodes.Status200OK // Status code here 
                    };
                }
            }
            catch(System.Exception)
            {
                //Response.StatusCode=StatusCodes.Status400BadRequest;
                return new JsonResult(new { message = "Not Allow" })
                {
                StatusCode = StatusCodes.Status400BadRequest // Status code here 
                };
            }
        }
    }
}