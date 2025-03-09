using GraphQLForDummies.Data;
using GraphQLForDummies.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<BookRepository>(); // Register repository
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>(); // Register GraphQL query

var app = builder.Build();

app.MapGraphQL(); // Enable GraphQL

app.Run();
