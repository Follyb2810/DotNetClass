using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
// using PizzaStore.DB;
using PizzaStore.Models;

var builder = WebApplication.CreateBuilder(args);
//! using SqlLite
var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";
    
builder.Services.AddEndpointsApiExplorer();
//! using entity framweork
// builder.Services.AddDbContext<PizzaDb>(options => options.UseInMemoryDatabase("items"));
//! using sqlLiet
builder.Services.AddSqlite<PizzaDb>(connectionString);
//* settings cors


builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "Making the Pizzas you love", Version = "v1" });
});
// 1) define a unique string
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// 2) define allowed domains, in this case "http://example.com" and "*" = all
//    domains, for testing purposes only.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
      builder =>
      {
          builder.WithOrigins(
            "http://example.com", "*");
      });
});
    
var app = builder.Build();
    
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI(c =>
   {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
   });
}
// 3) use the capability
app.UseCors(MyAllowSpecificOrigins);
app.MapGet("/", () => "Hello World!");
app.MapGet("/about", () => "in the about api ");
app.MapGet("/watch", () => "in the watch api ");
//! using class as data base
// app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
// app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
// app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
// app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
// app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));
//! using Microsoft.EntityFrameworkCore.InMemory
app.MapGet("/pizzas", async (PizzaDb db) => 
{

 return await db.Pizzas.ToListAsync();
}
);
 app.MapPost("/pizza", async (PizzaDb db, Pizza pizza) =>
{
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizza/{pizza.Id}", pizza);
});   
app.MapGet("/pizza/{id}", async (PizzaDb db, int id) => await db.Pizzas.FindAsync(id));
app.MapPut("/pizza/{id}", async (PizzaDb db, Pizza updatepizza, int id) =>
{
      var pizza = await db.Pizzas.FindAsync(id);
      if (pizza is null) return Results.NotFound();
      pizza.Name = updatepizza.Name;
      pizza.Description = updatepizza.Description;
      await db.SaveChangesAsync();
      return Results.NoContent();
});
app.MapDelete("/pizza/{id}", async (PizzaDb db, int id) =>
{
   var pizza = await db.Pizzas.FindAsync(id);
   if (pizza is null)
   {
      return Results.NotFound();
   }
   db.Pizzas.Remove(pizza);
   await db.SaveChangesAsync();
   return Results.Ok();
}); 
//! uisng sqlite
app.Run();


//! using sqlite
//? dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0
//* dotnet tool install --global dotnet-ef
// * dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0
//* dotnet ef migrations add InitialCreate
//* dotnet ef database update //! bto create database
//* dotnet run

//! cors in dotnet
// 1) define a unique string
// readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// 2) define allowed domains, in this case "http://example.com" and "*" = all
//    domains, for testing purposes only.
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy(name: MyAllowSpecificOrigins,
//       builder =>
//       {
//           builder.WithOrigins(
//             "http://example.com", "*");
//       });
// });
// // 3) use the capability
// app.UseCors(MyAllowSpecificOrigins);