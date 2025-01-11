using GenericRepository.Business;
using GenericRepository.Domain.Core;
using GenericRepository.Infrastructures.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositories();
builder.Services.AddBusiness();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/customers", async (ICustomerManager manager) =>
{
    await manager.AddAsync(new() { Id = 1, Name = "Marco" });

    return Results.Created();
})
.WithName("CreateCustomers")
.WithOpenApi();

app.MapGet("/customers", (ICustomerManager manager) =>
{
    return Results.Ok(manager.GetAll());
})
.WithName("GetCustomers")
.WithOpenApi();

app.MapGet("/customers/{id}", async (ICustomerManager manager, int id) =>
{
    var customer = await manager.GetByIdAsync(id);

    if (customer is null)
        return Results.NotFound();

    return Results.Ok(customer);
})
.WithName("GetCustomerById")
.WithOpenApi();

app.Run();

