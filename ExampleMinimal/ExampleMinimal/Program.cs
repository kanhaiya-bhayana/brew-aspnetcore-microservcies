// Step 1
var builder = WebApplication.CreateBuilder(args);

// Step 2 - Add services to the container.

// Step 3 - Build the application
var app = builder.Build();


/*
    Step 1 - 3 : Before building app
    Step 4 - 5 : After building app
 */


// Step 4 - Configure the HTTP request pipeline/Middleware/Routing/Authentication/Authorization, and so on...

// Step 5 - Run the application
app.Run();
