using Api.Business.Defintions;
using Api.Utils;
using Newtonsoft.Json;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<SettingsProvider>(builder.Configuration);

            SettingsProvider settingsProvider = builder.Configuration.Get<SettingsProvider>();
            DependencyInjection dependencyInjection = new DependencyInjection();
            dependencyInjection.Bootstrap(builder.Services, settingsProvider);

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddControllers().ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true)
                                                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
