using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using PersonalWebApi.EntityFramework;
using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new();
    builder.EntitySet<Blog>("Blogs");
    builder.EntitySet<Experience>("Experiences");
    builder.EntitySet<Project>("Projects");
    return builder.GetEdmModel();
}

builder.Services.AddDbContext<PersonalWebApiContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddScoped<BlogRepositories>();
builder.Services.AddScoped<ExperienceRepositories>();
builder.Services.AddScoped<ProjectRepositories>();
builder.Services.AddHealthChecks();
builder.Services.AddControllers()
    .AddOData(opt => opt.AddRouteComponents("v1", GetEdmModel()).Filter().Select().Expand().Count());
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PersonalWebApi", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PersonalWebApi v1"));
}

app.UseHttpsRedirection();
app.UseODataBatching();
app.UseRouting();

app.UseAuthorization();

app.UseHealthChecks("/healtz");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

public partial class Program { }