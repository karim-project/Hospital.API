
using Hospital.core;
using Hospital.core.Features.Doctors.Queries.Handelrs;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Data.Models;
using Hospital.Infrustructure;
using Hospital.Infrustructure.Data;
using Hospital.Infrustructure.Repositories;
using Hospital.Service;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Scalar.AspNetCore;

namespace Hospital.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var connectionString =
   builder.Configuration.GetConnectionString("DefaultConnection")
       ?? throw new InvalidOperationException("Connection string"
       + "'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDBcontext>(options =>
            {
                options.UseSqlServer(connectionString);
            });


            builder.Services.AddInfrustructureDependencies().AddServiceDependencies().AddCoreDependencies();

           


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
