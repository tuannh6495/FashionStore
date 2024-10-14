using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FashionStore.Infrastructure.Identity
{
	public class AccountDbContextFactory : IDesignTimeDbContextFactory<AccountDbContext>
	{
		public AccountDbContext CreateDbContext(string[] args)
		{
			// Lấy chuỗi kết nối từ appsettings.json hoặc cấu hình khác
			var optionsBuilder = new DbContextOptionsBuilder<AccountDbContext>();

			// Cấu hình chuỗi kết nối
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("FosDbContext");
			optionsBuilder.UseSqlServer(connectionString);

			return new AccountDbContext(optionsBuilder.Options);
		}
	}
}
