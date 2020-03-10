using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace RazorPagesLoginExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var passwordHasher = new PasswordHasher<string>();
            //var s = passwordHasher.HashPassword(null, "123456");
            //Console.WriteLine(s);
            //Console.ReadLine();
        CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
