﻿using CuaHangDoChoiAPI.BLL;
using CuaHangDoChoiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangDoChoiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageProductController : ControllerBase
    {
        private ImageProductBLL _bll = new ImageProductBLL();

        [HttpPost]
        public IActionResult Add(ImageProduct imageProduct)
        {
            if (_bll.AddImage(imageProduct) == 0) return Ok("Thành công");
            return BadRequest("Thất bại");
        }

        [HttpPut]
        public IActionResult Update(int id, ImageProduct imageProduct)
        {
            if (_bll.UpdateImage(id, imageProduct) == 0) return Ok("Thành công");
            return BadRequest("Thất bại");
        }

        [HttpPut]
        public IActionResult Delete(int id)
        {
            if (_bll.DeleteImage(id) == 0) return Ok("Thành công");
            return BadRequest("Thất bại");
        }

        [HttpGet]
        public IActionResult GetListImage(int productID)
        {
            return Ok(_bll.GetListImage(productID));
        }

        [HttpGet]
        public IActionResult GetImage(int id)
        {
            return Ok(_bll.GetImage(id));
        }
    }
}