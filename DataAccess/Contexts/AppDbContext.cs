
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
	{
			
	}
	
	public DbSet<SlideItem> slideItems { get; set; }
}
