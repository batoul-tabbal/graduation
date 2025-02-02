using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ÅÖÇİÉ ÇáÎÏãÇÊ
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
       
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        // Şã ÈÚãá ÅÚÏÇÏÇÊ Jwt ãÚÇííÑ ÇáßáãÇÊ ÇáÓÑíÉ
     
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key")),
         ValidateIssuer = false,
        ValidateAudience = false,
    };
});

// ÅÖÇİÉ ÎÏãÇÊ ÃÎÑì
builder.Services.AddControllers();

var app = builder.Build();

// ÅÚÏÇÏ ÇáãÕÇÏŞÉ
app.UseRouting();

// ÅÖÇİÉ ÇáãÕÇÏŞÉ
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// ÅÚÏÇÏ ãÓÇÑÇÊ ÇáÊØÈíŞ
app.MapControllers();

app.Run();