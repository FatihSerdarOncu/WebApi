using Menevis.Core.DAL;
using Menevis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.DAL.Abstract
{
	public interface IProductDAL : IEntityRepository<Product>
	{
		// Productla ilgili custom db operasyonları burda oluşturulabilir.
	}
	


}
