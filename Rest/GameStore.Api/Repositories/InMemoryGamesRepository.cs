namespace GameStore.Api.Repositories;
using GameStore.Api.Entities;


public class InMemoryGameRepository : IGamesRepository{
    private readonly List<Game> games = new(){
    new Game(){
        Id=1,
        Name="folly of the age",
        Genre="fight",
        Price=19.89m,
        ReleaseDate= new DateTime(2000,2,1),
        ImageUri="https://plcahold.co/100",
    },
    new Game(){
        Id=2,
        Name="fight in cub",
        Genre="roling",
        Price=9.3m,
        ReleaseDate= new DateTime(2060,2,1),
        ImageUri="https://plcahold.co/100",
    },
    new Game(){
        Id=3,
        Name="love in the air",
        Genre="love",
        Price=9m,
        ReleaseDate= new DateTime(2010,2,1),
        ImageUri="https://plcahold.co/100",
    },
};

public IEnumerable<Game> GetAll(){
    return games;
}
public Game? Get(int id){
   return games.Find(game => game.Id == id);
}
public void Create(Game game){
    game.Id = games.Max(game =>game.Id) +1;
    games.Add(game);
}
public void Update(Game updatedGame){
    var index = games.FindIndex(game => game.Id == updatedGame.Id);
    games[index] = updatedGame;
}
public void Delete(int id){
    var index = games.FindIndex(games =>games.Id == id);    
    games.RemoveAt(index);
}
    
}