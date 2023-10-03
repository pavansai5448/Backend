
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tinting_Banco_D180_Bangalore.Models;


namespace Nippon.Controller
{
    [ApiController]
    [EnableCors("corspolicy")]
    public class LoginController : ControllerBase
    {
        private TintingDepotRecordsContext tdrc;

        public LoginController(TintingDepotRecordsContext tdrc)
        {
            this.tdrc = tdrc;
        }
        [HttpGet]
        [Route("api/login/get/{Username}")]
        public List<LoginPage> GetUsername(string Username)
        {

            if (Username != null)
            {
                var records = tdrc.LoginPages.Where(x => x.Username == Username).Select(x => new LoginPage()
                {
                    Username = x.Username,
                    Password = x.Password
                }).ToList();
                return records;
            }
            return null;


        }
        [HttpPost]
        [Route("api/login/post")]
        public IActionResult AddContact(LoginPage login)
        {
            LoginPage login1 = new LoginPage();
            login1.Username = login.Username;
            login1.Password = login.Password;
            tdrc.LoginPages.Add(login1);
            tdrc.SaveChanges();
            return Ok(login1);
        }
    }
}