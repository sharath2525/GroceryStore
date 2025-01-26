var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GroceryStore>("grocerystore");

builder.Build().Run();
