using EduConnect.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

try
{
    using var context = new Connection();
    Console.WriteLine(context);
} catch (Exception ex)
{
    Console.WriteLine($"Database connection failed: {ex.Message}");
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
