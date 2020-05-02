﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menevis.BL.Abstract;
using Menevis.BL.Concrete;
using Menevis.DAL.Abstract;
using Menevis.DAL.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Menevis.WebApi
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IProductService,ProductManager>();
			services.AddScoped<IProductDAL,EFProductDAL>();
			services.AddSession();
			services.AddDistributedMemoryCache();
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseFileServer();
			app.UseSession();
			app.UseMvc(ConfigureRoutes);
		}

		private void ConfigureRoutes(IRouteBuilder routeBuilder)
		{
			routeBuilder.MapRoute("Default","{controller = Home}/{action = Index}/{id?}");
		}
	}
}