using GenericRepository.Domain.Core;
using GenericRepository.Infrastructures.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/customers", (ICustomerRepository customerRepo) =>
{
    customerRepo.UpdateAsync(new() { Id = "c001", Name = "Marco"});
})
.WithName("GetCustomers")
.WithOpenApi();

app.MapGet("/favourites", async (IFavouriteRepository favouriteRepo) =>
{
    var favourites = await favouriteRepo.GetAllAsync();
})
.WithName("GetCustomers")
.WithOpenApi();

app.Run();

