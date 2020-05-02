using Menevis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.Entities.Concrete
{
	public class Category:IEntity
	{
		public int CategoryId { get; set; }
		public int CategoryName { get; set; }
	}
}
