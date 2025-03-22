using ClassicCalculator;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Windows;

namespace ClassicCalculatorWpfApp
{
    public partial class App : Application
    {
        public App()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var configureLogging = new Action<ILoggingBuilder>(builder =>
            {
                builder.AddDebug();
                builder.AddConfiguration(configuration.GetSection("Logging"));
            });
            var loggerFactory = LoggerFactory.Create(configureLogging);
            var logger = loggerFactory.CreateLogger<App>();

            try
            {
                logger.LogInformation("Application starting...");
                Ioc.Default.ConfigureServices(
                    new ServiceCollection()
                        .AddLogging(configureLogging)
                        .AddTransient<ICalculator, Calculator>(provider => 
                            new Calculator(displayLength: 18, loggerFactory.CreateLogger<Calculator>()))
                        .AddTransient<CalculatorViewModel>()
                        .BuildServiceProvider());

            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Application start-up failed");
            }
        }
    }
}
