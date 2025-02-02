using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ����� �������
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
        // �� ���� ������� Jwt ������ ������� ������
     
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key")),
         ValidateIssuer = false,
        ValidateAudience = false,
    };
});

// ����� ����� ����
builder.Services.AddControllers();

var app = builder.Build();

// ����� ��������
app.UseRouting();

// ����� ��������
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// ����� ������ �������
app.MapControllers();

app.Run();