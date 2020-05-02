using Menevis.BL.Abstract;
using Menevis.DAL.Abstract;
using Menevis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.BL.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDAL _categoryDAL;
		public CategoryManager(ICategoryDAL CategoryDAL)
		{
			this._categoryDAL = CategoryDAL;
		}
		public List<Category> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
