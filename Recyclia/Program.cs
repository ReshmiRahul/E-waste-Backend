using Microsoft.EntityFrameworkCore;
using Recyclia.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//To set CORS - Policy 
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.WithOrigins("http://localhost:4200");
    });
});

builder.Services.AddDbContext<DataContextClass>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseSession();


app.UseHttpsRedirection();

app.UseCors("CorsPolicy"); //use course policy

app.UseAuthorization();

app.MapControllers();

app.Run();
