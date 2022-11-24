using Data.Mongo;
using Data.Mongo.Collections;
using Data.Mongo.Repo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMongo(builder.Configuration);

var app = builder.Build();

app.MapGet("/GetAllLogs", (IMongoRepository<Log> db) =>
    {
        return Results.Ok(db.GetAll());
    });

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();