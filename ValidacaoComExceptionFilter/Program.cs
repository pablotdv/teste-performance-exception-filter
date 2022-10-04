using Microsoft.AspNetCore.Hosting;

namespace ValidacaoComExceptionFilter;
internal class Program
{
    private static void Main(string[] args)
    {
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .Build()
            .Run();
    }
}
