using Biosfera3.Repository;
using Biosfera3.Service;
using Biosfera3.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<Contexto>(options =>
    options.UseNpgsql("Server=localhost;Database=biosfera3;Port=5432;User Id=postgres;Password=adminWEB123#"));

builder.Services.AddScoped<ICadastroPesquisadorService, CadastroPesquisadorService>();
builder.Services.AddScoped<ICadastroPesquisadorRepo, CadastroPesquisadorRepo>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
