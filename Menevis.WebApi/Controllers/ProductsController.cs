using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menevis.BL.Abstract;
using Menevis.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menevis.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

		private readonly IProductService _productService;
		public ProductsController(IProductService ProductService)
		{
			_productService = ProductService;
		}

		[HttpGet("getlist")]
		public ActionResult GetList()
		{
			var asd = _productService.GetAll();
			return Ok(asd);
		}
		[HttpPost("add")]
		public ActionResult Add(Product product)
		{
			_productService.Add(product);
			return Ok("Product has been added!");
		}

		[HttpPost("update")]
		public ActionResult Update(Product product)
		{
			_productService.Update(product);
			return Ok("Product has been updated!");
		}

		[HttpPost("delete")]
		public ActionResult Delete(int ProductId)
		{
			_productService.Delete(ProductId);
			return Ok("Product has been Deleted!");
		}

		[HttpGet]
		public ActionResult ProductGetCategory(int CategoryId)
		{
			var Model = _productService.GetByCategory(CategoryId);

			if (Model == null) return NotFound();

			return Ok();
		}
	}
}