using Menevis.Core.DAL.EntityFramework;
using Menevis.DAL.Abstract;
using Menevis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.DAL.Concrete.EntityFramework
{
	public class EFProductDAL : EFRepositoryBase<Product,ProjectContext>,IProductDAL
	{

	}
}
