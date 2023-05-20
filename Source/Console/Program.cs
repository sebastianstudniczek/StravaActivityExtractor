using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StravaActivityExtractor.Console.Configuration;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) =>
    {
        services.Configure<StravaOptions>(
            ctx.Configuration.GetSection(StravaOptions.Strava));
    })
    .Build();
