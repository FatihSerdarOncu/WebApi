using Menevis.BL.Abstract;
using Menevis.DAL.Abstract;
using Menevis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.BL.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductDAL _productDAL;
		public ProductManager(IProductDAL ProductDAL)
		{
			this._productDAL = ProductDAL;
		}
		public void Add(Product product) => _productDAL.Add(product);

		public void Delete(int productId) => _productDAL.Delete(productId);

		public List<Product> GetAll()
		{
			return _productDAL.GetList();
		}

		public List<Product> GetByCategory(int categoryId)
		{
			return _productDAL.GetList(p=>p.CategoryId == categoryId);
		}

		public void Update(Product product) => _productDAL.Update(product);
		
	}
}
