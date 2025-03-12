var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CleanArchitecture_2025_WebAPI>("cleanarchitecture-2025-webapi");

builder.Build().Run();
