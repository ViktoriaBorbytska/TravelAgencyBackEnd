using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelAgency.DatabaseAccess;
using TravelAgency.DatabaseAccess.Interfaces;

namespace TravelAgency.Module
{
    public static class ServiceCollectionExtensionMethods
    {
        public static IConfiguration Configuration { get; }

        public static void AddTravelAgency(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //serviceCollection.AddTransient<IDatabaseInitializer, DatabaseInitializer>();
            serviceCollection.AddTransient<ITravelAgencyDbContext, TravelAgencyDbContext>();
            //serviceCollection.AddTransient<IDatabaseSeeder, DatabaseSeeder>();
            //serviceCollection.AddTransient<JwtSecurityTokenHandler>();

            //BindProviders(serviceCollection);
            //BindFactories(serviceCollection);
            //BindRepositories(serviceCollection);
            //BindServices(serviceCollection);
            //BindHandlers(serviceCollection);

            //serviceCollection
            //    .AddIdentity<User, IdentityRole<int>>(options => { options.User.RequireUniqueEmail = true; })
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            //serviceCollection.AddDbContext<ApplicationDbContext>(cfg =>
            //{
            //    cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //});

            //serviceCollection.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireDigit = false;
            //});
        }

        //private static void BindHandlers(IServiceCollection serviceCollection)
        //{
        //    serviceCollection.AddTransient<ISessionHandler, SessionHandler>();
        //    serviceCollection.AddTransient<IRoomAvailabilityHandler, RoomAvailabilityHandler>();
        //}

        //private static void BindProviders(IServiceCollection serviceCollection)
        //{
        //    serviceCollection.AddTransient<IDateTimeProvider, DateTimeProvider>();
        //}

        //private static void BindFactories(IServiceCollection serviceCollection)
        //{
        //    serviceCollection.AddTransient<IJavascriptWebTokenFactory, JavascriptWebTokenFactory>();
        //    serviceCollection.AddTransient<ISecurityTokenDescriptorFactory, SecurityTokenDescriptorFactory>();
        //}

        //private static void BindRepositories(IServiceCollection serviceCollection)
        //{
        //    serviceCollection.AddTransient<IApplicationUserRepository, ApplicationUserRepository>();
        //    serviceCollection.AddSingleton<IApplicationRoleRepository, ApplicationRoleRepository>();
        //    serviceCollection.AddTransient<ISessionRepository, SessionRepository>();
        //    serviceCollection.AddTransient<IHotelRepository, HotelRepository>();
        //    serviceCollection.AddTransient<IOrderRepository, OrderRepository>();
        //    serviceCollection.AddTransient<IClientRepository, ClientRepository>();
        //    serviceCollection.AddTransient<IRoomRepository, RoomRepository>();
        //    serviceCollection.AddTransient<ICreditCardRepository, CreditCardRepository>();
        //}

        //private static void BindServices(IServiceCollection serviceCollection)
        //{
        //    serviceCollection.AddTransient<IAccountService, AccountService>();
        //    serviceCollection.AddTransient<IHotelService, HotelService>();
        //    serviceCollection.AddTransient<IRoomService, RoomService>();
        //    serviceCollection.AddTransient<IOrderService, OrderService>();
        //    serviceCollection.AddTransient<IImageService, ImageService>();
        //}
    }
}