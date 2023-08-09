using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ohmybook;
using OMB.Adapter.Repository;
using OMB.Core.Application;
using OMB.Core.Domain;
using OMB.Core.Domain.Mappers;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            IHostBuilder CreateHostBuilder(string[] strings)
            {
                return Host.CreateDefaultBuilder()
                    .ConfigureServices((_, services) =>
                    {

                        var mappingConfig = new MapperConfiguration(mc =>
                        {
                            mc.AddProfile(new BookMappingProfile());
                        });

                        IMapper mapper = mappingConfig.CreateMapper();
                        services.AddSingleton(mapper);

                        //services.AddAutoMapper(typeof(BookMappingProfile));
                        services.AddSingleton<IBookProcessor, BookProcessor>();
                        services.AddSingleton<IBookRepository, BookRepository>();
                        services.AddSingleton<IUserBookshelfRepository, UserBookshelfRepository>();
                        services.AddSingleton<App>();

                  
                    });
            }

            try
            {
                services.GetRequiredService<App>().Run(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
