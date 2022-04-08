using Microsoft.Extensions.DependencyInjection;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.EzeTap;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.PineLabs;
using Zone.DataProvider.DigitalPayment.EzeTap;
using Zone.DataProvider.DigitalPayment.PineLabs;

namespace ZPay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection();
            ConfigureServices(services);
            services.AddScoped<ZPay>();
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();
                var zpay = serviceProvider.GetRequiredService<ZPay>();
                Application.Run(zpay);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ISaleRequestProvider, SaleRequestProvider>();
            services.AddScoped<IPaymentProvider, PaymentProvider>();
        }
    }
}