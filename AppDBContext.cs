using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBiz
{
	public class Client 
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string WhatsApp { get; set; } = string.Empty;
		public string Telegram { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Tags { get; set; } = string.Empty;
		public string Notes { get; set; } = string.Empty;
		public string CreatedAt	 { get; set; } = string.Empty;
	}

	public class Order
	{
		public int Id { get; set; }
		public string Client { get; set; } = string.Empty;
		public string OrderName { get; set; } = string.Empty;
		public int OrderAmount { get; set; }

		public string status { get; set; } = string.Empty;
		public string DeadLine { get; set; } = string.Empty;
		public string CreatedAt { get; set; } = string.Empty;

	}

	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public int Price { get; set; }
	}
	public class Finance
	{
		public int Id { get; set; }

		public string ClientName { get; set; } = string.Empty;
		public string Order { get; set; } = string.Empty;
		public int OrderAmount { get; set; }
	}

	public class AppDBContext : DbContext
	{
		public DbSet<Client> clients { get; set; }

		public DbSet<Order> orders { get; set; }

		public DbSet<Finance> finances { get; set; }

		public DbSet<Product> products { get; set; }
		public AppDBContext()
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("DataSource=database.db");
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>().HasIndex(c => c.Email).IsUnique();
			modelBuilder.Entity<Order>().HasIndex(o => o.Id).IsUnique();
			modelBuilder.Entity<Finance>().HasIndex(f => f.Id).IsUnique();
			modelBuilder.Entity<Product>().HasIndex(p => p.Id).IsUnique();
		}
	}
}
