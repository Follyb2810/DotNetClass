namespace GameStore.Api.Endpoint;
using GameStore.Api.Entities;
using GameStore.Api.Repositories;
using GameStore.Api.Dtos;


static public class GamesEndpoint
{
    //! also valid but verbose
    // List<Game> gamesV = new List<Game>(){
    //     new Game(){
    //         Id=1,
    //         Name="folly of the age",
    //         Genre="fight",
    //         Price=19.89m
    //     }
    // };

    public static RouteGroupBuilder MapGamesEndpoints(this IEndpointRouteBuilder routes)
    {
    // InMemoryGameRepository repository = new();  
        const string GetGameEndpointName = "GetGame";
        var group = routes.MapGroup("/games").WithParameterValidation();


        //! app.MapGet("/games", () => games);
        // group.MapGet("/", () => games);
        //! using repository
        group.MapGet("/", (IGamesRepository repository) =>repository.GetAll().Select(game =>game.AsDto()) );

        group.MapGet("/{id}", (IGamesRepository repository,int id) =>
        {
             //! using repository
            Game? singlegame = repository.Get(id);
            return singlegame is not null ? Results.Ok(singlegame.AsDto()) : Results.NotFound();   
            // Game? singlegame = games.Find(game => game.Id == id);
            // if (singlegame is null)
            // {
            //     return Results.NotFound();
            // }
            // return Results.Ok(singlegame);
        }).WithName(GetGameEndpointName);


        // group.MapPost("/", (IGamesRepository repository,Game game) =>
        //! using dtos
        group.MapPost("/", (IGamesRepository repository,CreateGameDto gameDto) =>
        {
            //! usng dto
            Game game = new(){
                Name = gameDto.Name,
                Genre = gameDto.Genre,
                Price = gameDto.Price,
                ReleaseDate = gameDto.ReleaseDate,
                ImageUri = gameDto.ImageUri,
            };
            //! using repository method
            
            repository.Create(game);
            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
            // game.Id = games.Max(game => game.Id) + 1;
            // games.Add(game);
            // return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
        });


        // group.MapPut("/{id}", (IGamesRepository repository,int id, Game updateGamee) =>
        //!using dto
        group.MapPut("/{id}", (IGamesRepository repository,int id, UpdateGameDto updateGameeDto) =>
        {
            //! repository pattern
            Game? existingGame = repository.Get(id);
            if (existingGame is null)
            {
                return Results.NotFound();
            }
            existingGame.Name = updateGameeDto.Name;
            existingGame.Price = updateGameeDto.Price;
            existingGame.Genre = updateGameeDto.Genre;
            existingGame.ReleaseDate = updateGameeDto.ReleaseDate;
            existingGame.ImageUri = updateGameeDto.ImageUri;
            repository.Update(existingGame);
            return Results.NoContent();
            // Game? existingGame = games.Find(game => game.Id == id);
            // if (existingGame is null)
            // {
            //     return Results.NotFound();
            // }
            // existingGame.Name = updateGamee.Name;
            // existingGame.Price = updateGamee.Price;
            // existingGame.Genre = updateGamee.Genre;
            // existingGame.ReleaseDate = updateGamee.ReleaseDate;
            // existingGame.ImageUri = updateGamee.ImageUri;
            // return Results.NoContent();

        });


        group.MapDelete("/{id}", (IGamesRepository repository,int id) =>
        {
            //! using reposotory pattern
            Game? game =repository.Get(id);
            if (game is not null)
            {
                repository.Delete(id);
            }
            // return Results.NotFound();
            return Results.NoContent();
            // Game? game = games.Find(games => games.Id == id);
            // if (game is not null)
            // {
            //     games.Remove(game);
            // }
            // // return Results.NotFound();
            // return Results.NoContent();
            // Game? findGame = games.find(games =>games.Id === id);
            // if(findGame is null){
            //     return Results.NotFound();
            // } 
            // games.Remove(findGame);
            // return Results.NoContent()
        });
        
        return group;
    }
}