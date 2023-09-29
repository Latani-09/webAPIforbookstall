using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Interface;
using webapi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var MyAllowSpecificOrigins = "MyAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:4200").AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
                      });
});
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default Connection"));
});

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IGalleryService, GalleryService>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option=>
{
    option.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
        ValidateIssuer = false,
        ValidateAudience = false

    };

}
    );


var app = builder.Build();
//to give acces to frontend from api
app.UseCors(MyAllowSpecificOrigins);


app.MapControllers();
//app.UseAuthorization();

app.Run();
