using Sstu.Rasp.BLL;
using Sstu.Rasp.BLL.Contracts;
using Sstu.Rasp.DAL.Contracts;
using Sstu.Rasp.DAL.Dao;
using Microsoft.Extensions.DependencyInjection;

namespace Sstu.Rasp.DI
{
    public class ContainerConfigurator
    {
        public void Configure(IServiceCollection services, string connectionString)
        {
            // Business Logic Layer
            services.AddSingleton<IScheduleLogic, ScheduleLogic>();


            // Data Access Layer
            services.AddSingleton<IScheduleDao>(s => new ScheduleDao(connectionString));

        }
    }
}
