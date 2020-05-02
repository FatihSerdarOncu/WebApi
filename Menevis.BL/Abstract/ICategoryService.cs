using Menevis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.BL.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetAll();
		void Add(Category product);
		void Update(Category product);
		void Delete(int CategoryId);
	}
}
