using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration((builderContext, config) =>
				{
					config.AddJsonFile("hosting.json", false);
					config.
				})
				.UseStartup<Startup>()
				.Build();
		}
	}
}
