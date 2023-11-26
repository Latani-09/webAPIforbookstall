using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using webapi;
using webapi.Data;
using webapi.Entities;
using webapi.Interface;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSession(); ;
var MyAllowSpecificOrigins = "MyAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:4200")
                          .AllowCredentials()
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
services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.None; // or SameSiteMode.Lax
});

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
/* builder.Services.AddAuthorization(opt => 
{
    opt.AddPolicy("requireAdminRole",
                policy => policy.RequireRole("Admin","Moderator")
              );
});*/
// Register IDistributedCache with DistributedMemoryCache implementation
services.AddDistributedMemoryCache();


/*services.AddSession(options =>
{
    options.Cookie.Name = "CartSession"; // Change to your preferred cookie name
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
});*/
// Configure session options

builder.Services .AddHttpContextAccessor();
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
    await SeedData.SeedBook(context);

}
catch (Exception ex) {
    Console.WriteLine(ex);
        }
app.UseAuthentication();
app.UseAuthorization();
//app.UseSession();
app.MapControllers();//app.UseAuthorization();

app.Run();

