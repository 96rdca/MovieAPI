using System;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MovieAPI_IonHH.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{ }

	public DbSet<Movies> Movies { get; set; }
	public DbSet<Reviews> Reviews { get; set; }

	//public IConfiguration Configuration { get;  }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.Seed();
	}
}

