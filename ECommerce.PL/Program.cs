using Ecommerce.BL.Interfaces;
using Ecommerce.BL.Mapping;
using Ecommerce.BL.Services;
using Ecommerce.DL;
using Ecommerce.DL.Contracts;
using Ecommerce.DL.Repositories;

namespace ECommerce.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddDbContext<ApplicationDBContext>();

            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddAutoMapper(x => x.AddProfile<MappingProfile>());

            var app = builder.Build();
            
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
