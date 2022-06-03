using CuaHangDoChoiAPI.BLL;
using CuaHangDoChoiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangDoChoiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryBLL _bll = new CategoryBLL();

        [HttpPost]
        public IActionResult PostCategory(Category category)
        {
            if (_bll.AddCategory(category) == 0) return Ok("Thành công");
            return BadRequest("Lỗi");
        }

        [HttpPut]
        public IActionResult PutCategory(int id, Category category)
        {
            if (_bll.UpdateCategory(id, category) == 0) return Ok("Thành công");
            return BadRequest("Lỗi");
        }

        [HttpPut]
        public IActionResult DeleteCategory(int id)
        {
            if (_bll.DeleteCategory(id) == 0) return Ok("Thành công");
            return BadRequest("Lỗi");
        }

        [HttpGet]
        public IActionResult GetCategoryList(string keyword)
        {
            return Ok(_bll.GetListCategory(keyword));
        }

        [HttpGet]
        public IActionResult GetCategory(int id)
        {
            return Ok(_bll.GetCategory(id));
        }
    }
}