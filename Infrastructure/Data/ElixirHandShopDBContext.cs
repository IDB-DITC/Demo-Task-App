using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Infrastructure.Data
{
	public class ElixirHandShopDBContext : IdentityDbContext<AppUser>
	{
		public ElixirHandShopDBContext(DbContextOptions<ElixirHandShopDBContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductBrand> ProductBrands { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

		//public DbSet<Core.Entities.Identity.Address> Addresses { get; set; }



		//Here we areapplying Product Configuration on migration
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<Core.Entities.Identity.Address>().			HasKey(u =>  u.Id);
			//modelBuilder.Entity<IdentityUserLogin<string>>()
			//.HasKey(u => new { u.UserId, u.LoginProvider, u.ProviderKey });

			//modelBuilder.Entity<IdentityUserRole<string>>()

			//.HasKey(r => new { r.UserId, r.RoleId });

			//modelBuilder.Entity<Core.Entities.Identity.Address>().HasNoKey();

			try
			{
				var context = modelBuilder;

				var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				Console.WriteLine(path);

				//ProductsBrnads Data does not exist
				//Then go ahead and read it from the following path and store into brands variable, thanks
				var brandsData = File.ReadAllText(path + @"/Data/SeedData/brands.json");

				//Now go ahead, deserialized everything you read from above path, thanks
				var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

				context.Entity<ProductBrand>().HasData(brands);




				//ProductTypes Data does not exist

				//Then go ahead and read it from the following path and store into brands variable, thanks
				var typesData = File.ReadAllText(path + @"/Data/SeedData/types.json");

				//Now go ahead, deserialized everything you read from above path, thanks
				var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
				context.Entity<ProductType>().HasData(types);


				//Products Data does not exist

				//Then go ahead and read it from the following path and store into brands variable, thanks
				var productsData = File.ReadAllText(path + @"/Data/SeedData/products.json");

				//Now go ahead, deserialized everything you read from above path, thanks
				var products = JsonSerializer.Deserialize<List<Product>>(productsData);

				context.Entity<Product>().HasData(products);


				//Products Data does not exist
				//Then go ahead and read it from the following path and store into brands variable, thanks
				var deliveryData = File.ReadAllText(path + @"/Data/SeedData/delivery.json");

				//Now go ahead, deserialized everything you read from above path, thanks
				var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryData);

				context.Entity<DeliveryMethod>().HasData(deliveryMethods);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}


	}
}