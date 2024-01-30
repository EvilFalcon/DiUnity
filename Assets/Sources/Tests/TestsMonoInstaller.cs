using UniCtor.Installers;
using UniCtor.Services;
using UnityEngine;

namespace Sources.Tests
{
    public class TestsMonoInstaller : MonoInstaller
    {
        public override void OnConfigure(IServiceCollection services)
        {
            services
                .RegisterAsScoped<ILogServiceConfiguration>(
                    serviceCollection =>
                        new LogServiceConfiguration(serviceCollection.GetService<IDateTimeService>().LogDay)
                )
                .RegisterAsSingleton<ILogService, LogService>()
                .RegisterAsScoped<ITestService, TestService>()
                .RegisterAsTransient<IDateTimeService, DateTimeService>()
                //.RegisterAsSingleton<ILogService,LogService>()
                ;
                // .RegisterAsScoped<ILogServiceConfiguration, LogServiceConfiguration>();
                // .RegisterAsScoped<ILogServiceConfiguration>(new LogServiceConfiguration(DayOfWeek.Friday))
                
            Debug.Log("OnConfigure");
        }
    }
}