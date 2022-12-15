using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using WebVehicle.DataContext;
using WebVehicle.DataContext.DataDummy;

namespace WebVehicle
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetService<IConfiguration>();
            var sqlConnection = configuration.GetSection(nameof(SqlServerConnection)).Get<SQLServerConnection>();
            services.AddDbContextPool<ApplicationDBContext>(options => options.UseSqlServer(
                        sqlConnection.ConnectionString
                     ));
        }

        public void IncludeMigrationDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
                context.Database.Migrate();

                var insertDataDummy = serviceScope.ServiceProvider.GetRequiredService<IInsertDataDummy>();
                insertDataDummy.InsertData();
            }
        }
    }
}
