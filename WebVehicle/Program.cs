using Microsoft.OpenApi.Models;
using WebVehicle;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup();
var bindings = new Bindings();

builder.Services.AddControllers();
startup.ConfigureServices(builder.Services);
bindings.RegisterDependencyInjection(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebVehicle", Version = "v1" });
});

var app = builder.Build();
startup.IncludeMigrationDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebVehicle v1"));
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
