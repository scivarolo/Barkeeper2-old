using Barkeeper2.Data;
using Barkeeper2.Interfaces;
using Barkeeper2.Models;
using Barkeeper2.Repositories;
using Barkeeper2.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Barkeeper2 {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			services.AddDefaultIdentity<ApplicationUser>()
				.AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddIdentityServer()
				.AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

			services.AddAuthentication()
				.AddIdentityServerJwt();

			services.AddMvc(options => options.EnableEndpointRouting = false)
				.AddNewtonsoftJson();

			// In production, the React files will be served from this directory
			services.AddSpaStaticFiles(configuration => {
				configuration.RootPath = "ClientApp/build";
			});

			// Barkeeper2 Repositories DI
			services.AddScoped<ICocktailIngredientsRepository, CocktailIngredientsRepository>();
			services.AddScoped<ICocktailsRepository, CocktailsRepository>();
			services.AddScoped<IIngredientsRepository, IngredientsRepository>();
			services.AddScoped<IProductsRepository, ProductsRepository>();
			services.AddScoped<IUserCocktailsRepository, UserCocktailsRepository>();
			services.AddScoped<IUserHistoriesRepository, UserHistoriesRepository>();
			services.AddScoped<IUserProductsRepository, UserProductsRepository>();
			services.AddScoped<IUserShoppingRepository, UserShoppingRepository>();
			services.AddScoped<IUserTabsRepository, UserTabsRepository>();

			// Barkeeper2 Services DI
			services.AddScoped<ICocktailIngredientsService, CocktailIngredientsService>();
			services.AddScoped<ICocktailsService, CocktailsService>();
			services.AddScoped<IIngredientsService, IngredientsService>();
			services.AddScoped<IProductsService, ProductsService>();
			services.AddScoped<IUserCocktailsService, UserCocktailsService>();
			services.AddScoped<IUserHistoriesService, UserHistoriesService>();
			services.AddScoped<IUserProductsService, UserProductsService>();
			services.AddScoped<IUserShoppingService, UserShoppingService>();
			services.AddScoped<IUserTabsService, UserTabsService>();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			} else {
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSpaStaticFiles();

			app.UseAuthentication();
			app.UseIdentityServer();

			app.UseMvc(routes => {
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa => {
				spa.Options.SourcePath = "../Barkeeper.UI";

				if (env.IsDevelopment()) {
					// spa.UseReactDevelopmentServer(npmScript: "start");
					spa.UseProxyToSpaDevelopmentServer("http://localhost:8081");
				}
			});
		}
	}
}
