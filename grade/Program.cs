using grade.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


//  ”ÃÌ· «·Œœ„« 
builder.Services.AddControllers();
builder.Services.AddSingleton<UserServices>(); //  ”ÃÌ· «·Œœ„…

var app = builder.Build();

// ≈÷«›… «·Œœ„« 
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
        // ﬁ„ »⁄„· ≈⁄œ«œ«  Jwt „⁄«ÌÌ— «·ﬂ·„«  «·”—Ì…
     
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key")),
         ValidateIssuer = false,
        ValidateAudience = false,
    };
});

// ≈÷«›… Œœ„«  √Œ—Ï
builder.Services.AddControllers();



// ≈⁄œ«œ «·„’«œﬁ…
app.UseRouting();

// ≈÷«›… «·„’«œﬁ…
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// ≈⁄œ«œ „”«—«  «· ÿ»Ìﬁ
app.MapControllers();

app.Run();