using CuaHangDoChoiAPI.BLL;
using CuaHangDoChoiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangDoChoiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductBLL _bll = new ProductBLL();

        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            if (_bll.AddProduct(product) == 0)
            {
                return Ok(product);
            }

            return BadRequest("Error");
        }

        [HttpPut]
        public IActionResult PutProduct(int id, Product product)
        {
            if (_bll.UpdateProduct(id, product) == 0) return Ok(product);
            return BadRequest("Error");
        }

        [HttpPut]
        public IActionResult DeleteProduct(int id)
        {
            if (_bll.DeleteProduct(id) == 0) return Ok("Success");
            return BadRequest("Error");
        }

        [HttpGet]
        public IActionResult GetProductList(string keyword)
        {
            return Ok(_bll.GetListProduct(keyword));
        }

        [HttpGet]
        public IActionResult GetProductByCategory(int idCategory)
        {
            return Ok(_bll.GetProductByCategory(idCategory));
        }

        [HttpGet]
        public IActionResult GetProductIsSale()
        {
            return Ok(_bll.GetProductIsSale());
        }

        [HttpGet]
        public IActionResult GetProductIsHot()
        {
            return Ok(_bll.GetProductIsHot());
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            return Ok(_bll.GetProductById(id));
        }
    }
}