using JWTRefreshToken.Data;
using JWTRefreshToken.Data.Mapping;
using JWTRefreshToken.Exceptions;
using JWTRefreshToken.Extension;
using JWTRefreshToken.Model;
using JWTRefreshToken.Service;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;

using System.Text;

var builder = WebApplication.CreateBuilder(args);

// -----------------------
// Add Services
// -----------------------

builder.Services.AddHttpContextAccessor();

builder.Services.AddExceptionHandler<GlobalExceptions>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

// -----------------------
// Swagger + JWT Lock
// -----------------------

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "JWT Refresh Token API",
        Version = "v1"
    });

options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
{
    Description = "Enter token as: Bearer {your token}",
    Name = "Authorization",
    In = ParameterLocation.Header,
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
    BearerFormat = "JWT"
});

    options.AddSecurityRequirement(doc => new OpenApiSecurityRequirement
{
    { new OpenApiSecuritySchemeReference("Bearer", doc), new List<string>() }
});

});

// -----------------------
// Database
// -----------------------

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    );
});

// -----------------------
// Identity
// -----------------------

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// -----------------------
// Custom Services
// -----------------------

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

// -----------------------
// AutoMapper
// -----------------------

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

// -----------------------
// JWT + Identity Extensions
// -----------------------

builder.Services.ConfigureIdentity();
builder.Services.ConfigureJwt(builder.Configuration);
builder.Services.ConfigureCors();

// -----------------------
// Build App
// -----------------------

var app = builder.Build();

app.UseCors("CorsPolicy");

// -----------------------
// Swagger
// -----------------------

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

// -----------------------
// Middleware
// -----------------------

app.UseHttpsRedirection();

app.UseExceptionHandler();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
