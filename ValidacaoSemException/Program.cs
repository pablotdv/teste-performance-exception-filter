using Microsoft.AspNetCore.Hosting;

namespace ValidacaoSemException;
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
