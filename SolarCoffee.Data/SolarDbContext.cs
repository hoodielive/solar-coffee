using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SolarCoffee.Data
{
	public class SolarDbContext : IdentityDbContext
	{
		public SolarDbContext() { }
		public SolarDbContext(DbContextOptions options) : base(optional) { }

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
	}
}
