var builder = WebApplication.CreateBuilder(args);

// Ajoutez les services nécessaires à l'application
builder.Services.AddControllers();

var app = builder.Build();

// Configurez le routage des contrôleurs
app.MapControllers();

app.Run();
