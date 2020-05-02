using Menevis.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menevis.DAL.Concrete.EntityFramework
{
	
	public class ProjectContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// You have use your connection string
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-F39R5FD\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
