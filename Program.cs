using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Interface;
using webapi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using webapi.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using webapi;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.OpenApi.Writers;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
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


builder.Services.AddIdentityCore<AppUser>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
})
                .AddRoles<AppRole>()
                .AddRoleManager<RoleManager<AppRole>>()
                .AddSignInManager<SignInManager<AppUser>>()
                .AddRoleValidator<RoleValidator<AppRole>>()
                .AddEntityFrameworkStores<DataContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
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
using var scope = app.Services.CreateScope();
var servicesdatacontext = scope.ServiceProvider;
try
{
    var context = servicesdatacontext.GetRequiredService<DataContext>();
    var userManager = servicesdatacontext.GetRequiredService<UserManager<AppUser>>();
    var roleManager = servicesdatacontext.GetRequiredService<RoleManager<AppRole>>();
    await context.Database.MigrateAsync();
    await SeedData.Seed(userManager,
                        roleManager);
}
catch (Exception ex) { }


app.MapControllers();//app.UseAuthorization();

app.Run();

