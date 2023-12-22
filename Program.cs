using JwtAspNet.Services;
using JwtAspNet.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<TokenService>();


var app = builder.Build();

app.MapGet("/", (TokenService service) =>
{
   return service.Create(new User(
        Id : 1, 
        Name : "Rafael Anacleto",
        Image : "imagem",
        Email : "rafael.ferreira.anacleto@gmail.com",
        Password : "213213erwqqw",
        Roles : new string[] {"Student", "priminu"}
));
});


    

app.Run();
