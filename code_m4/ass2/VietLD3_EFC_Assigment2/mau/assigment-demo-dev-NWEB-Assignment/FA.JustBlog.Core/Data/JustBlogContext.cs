using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core
{
	public partial class JustBlogContext : IdentityDbContext
	{
		public JustBlogContext()
		{

		}
		public JustBlogContext(DbContextOptions<JustBlogContext> ops) : base(ops)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Category).Assembly);
			modelBuilder.Seed();
			OnModelCreatingPartial(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
		/*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = @"Server=admin;Database=JustBlogDemo;Integrated Security=True";
			base.OnConfiguring(optionsBuilder);
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(connectionString);
			}
			//optionsBuilder.UseSqlServer("Server=admin;Database=FAJustBlog;Integrated Security=True");
		}*/

		public DbSet<Category> Categories { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<PostTagMap> PostTagMaps { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }

	}
}
