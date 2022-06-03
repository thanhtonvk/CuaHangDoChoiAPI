using CuaHangDoChoiAPI.BLL;
using CuaHangDoChoiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangDoChoiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AccountBLL _bll = new AccountBLL();

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            Account account = _bll.Login(username, password);
            return Ok(account);
        }

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            if (_bll.Register(username, password) == 0) return Ok();
            return BadRequest();
        }
    }
}