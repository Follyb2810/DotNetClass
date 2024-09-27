using GameStore.Api.Entities;
using GameStore.Api.Endpoint;
using GameStore.Api.Repositories;


var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddScoped<IGamesRepository,InMemoryGameRepository>();
builder.Services.AddSingleton<IGamesRepository,InMemoryGameRepository>();
var app = builder.Build();
app.MapGamesEndpoints();
    
app.MapGet("/", () => "Hello World!");
app.Run();

  
//? post
// app.MapGet("/games/{id}", (int id) =>{
//     Game? singlegame = games.Find(game => game.Id == id);
//     if (singlegame is null)
//     {
//         return Results.NotFound();
//     }
//     return Results.Ok(singlegame);
// }).WithName(GetGameEndpointName);

//? post
// app.MapPost("/games", (Game game) =>
// {
//     game.Id = games.Max(game => game.Id) + 1;
//     games.Add(game);
//     return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
// });

//? put
// app.MapPut("/games/{id}", (int id,Game updateGamee) =>
// {
//     Game? existingGame = games.Find(game => game.Id == id);
//     if (existingGame is null)
//     {
//         return Results.NotFound();
//     }
//     existingGame.Name = updateGamee.Name;
//     existingGame.Price = updateGamee.Price;
//     existingGame.Genre = updateGamee.Genre;
//     existingGame.ReleaseDate = updateGamee.ReleaseDate;
//     existingGame.ImageUri = updateGamee.ImageUri;
//     return Results.NoContent();

// });


//? delete
// app.MapDelete("/games/{id}",(int id )=>{
//     Game? game = games.Find(games =>games.Id == id);
//     if(game is not null){
//     games.Remove(game);
//     } 
//         // return Results.NotFound();
//     return Results.NoContent();
//     // Game? findGame = games.find(games =>games.Id === id);
//     // if(findGame is null){
//     //     return Results.NotFound();
//     // } 
//     // games.Remove(findGame);
//     // return Results.NoContent()
// });
