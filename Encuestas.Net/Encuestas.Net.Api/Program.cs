using Encuestas.Net.Infrastructure.Ioc.DependencyInjections;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependencyInjection(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllHeaders",
          builder =>
          {
              builder
                        .AllowAnyHeader()
                        .SetIsOriginAllowed((Host) => true)
                        .AllowAnyMethod()
              .AllowCredentials();
          });

});

builder.Services.AddControllers().AddJsonOptions(x =>
				x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors("AllowAllHeaders");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
