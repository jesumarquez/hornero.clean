using Hornero.Clean.Api.Errors;
using Hornero.Clean.Application;
using Hornero.Clean.Infrastrucutre;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
    
    builder.Services.AddControllers();
    builder.Services.AddSingleton<ProblemDetailsFactory,HorneroCleanProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
