using AbrarHamdy_S1.Data;
using AbrarHamdy_S1.Repositories.CategoryRepos;
using AbrarHamdy_S1.Repositories.DirectoryRepos;
using AbrarHamdy_S1.Repositories.MovieRepos;
using AbrarHamdy_S1.Repositories.NationalityRepos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connect = builder.Configuration.GetConnectionString("DefultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connect));

builder.Services.AddScoped<IMovieRepo, MovieRepo>();
builder.Services.AddScoped<IDirectoryRepo, DirectoryRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<INationalityRepo, NationalityRepo>();

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
