var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages(); // Razor Pages
builder.Services.AddEndpointsApiExplorer(); // Swagger
builder.Services.AddSwaggerGen();

// AddDbContext<ApplicationDbContext>(...) etc.

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(); // para Razor
app.UseRouting();
app.UseAuthorization();

app.MapControllers(); // API REST
app.MapRazorPages();  // Razor Pages

app.Run();
