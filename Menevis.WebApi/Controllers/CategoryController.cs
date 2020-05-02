using Menevis.BL.Abstract;
using Menevis.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menevis.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("getlist")]
		public ActionResult GetList()
		{
			var asd = _productService.GetAll();
			return Ok(asd);
		}

		[HttpPost("add")]
		public ActionResult Add(Category category)
		{
			_categoryService.Add(category);
			return Ok("Category has been added!");
		}

		[HttpPost("update")]
		public ActionResult Update(Category category)
		{
			_categoryService.Update(category);
			return Ok("Category has been updated!");
		}

		[HttpPost("delete")]
		public ActionResult Delete(int CategoryId)
		{
			_categoryService.Delete(CategoryId);
			return Ok("Category has been Deleted!");
		}
	}
}
