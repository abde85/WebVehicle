using WebVehicle.DataContext.DataDummy;
using WebVehicle.DataContext.Service;

namespace WebVehicle
{
    public class Bindings
    {
        public void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IServiceVehicle, ServiceVehicle>();
            services.AddScoped<IInsertDataDummy, InsertDataDummy>();
        }
    }
}
