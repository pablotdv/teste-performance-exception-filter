using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

[MemoryDiagnoser]
public class BenchmarkApi
{
    private HttpClient _httpClientExceptionFilter;
    private HttpClient _httpClientComTryCatch;
    private HttpClient _httpClientSemException;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _httpClientExceptionFilter = new WebApplicationFactory<ValidacaoComExceptionFilter.Startup>()
            .WithWebHostBuilder(configuration =>
            {
                configuration.ConfigureLogging(logging => { });
            }).CreateClient();

        _httpClientComTryCatch = new WebApplicationFactory<ValidacaoComTryCatch.Startup>()
            .WithWebHostBuilder(configuration =>
            {
                configuration.ConfigureLogging(logging => { });
            }).CreateClient();

        _httpClientSemException = new WebApplicationFactory<ValidacaoSemException.Startup>()
            .WithWebHostBuilder(configuration =>
            {
                configuration.ConfigureLogging(logging => { });
            }).CreateClient();
    }

    [Benchmark]
    public Task ValidacaoComExceptionFilter()
    {
        return _httpClientExceptionFilter.PostAsync("/api/produtos", null);
    }
    
    [Benchmark]
    public Task ValidacaoComTryCatch()
    {
        return _httpClientComTryCatch.PostAsync("/api/produtos", null);
    }

    [Benchmark(Baseline = true)]
    public Task ValidacaoSemException()
    {
        return _httpClientSemException.PostAsync("/api/produtos", null);
    }    
}
