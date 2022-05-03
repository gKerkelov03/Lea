using Lea.Data;
using Lea.Data.Seeding;
using Lea.Web.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Configure Services

builder.Services.AddAutoMapper();
builder.Services.AddCloudinary(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLeaDbContext(builder.Configuration);
builder.Services.AddLeaIdentity(builder.Configuration);

#endregion

var app = builder.Build();

#region Seed Data

using var serviceScope = ((IApplicationBuilder)app).ApplicationServices.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<LeaDbContext>();

if (!dbContext.Database.CanConnect())
{
    dbContext.Database.Migrate();
    await new LeaDbContextSeeder(dbContext, serviceScope.ServiceProvider).SeedAsync();
}

#endregion

#region Configure Pipeline

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

#endregion