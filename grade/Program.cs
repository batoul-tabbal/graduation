using grade.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.DependencyInjection;




var builder = WebApplication.CreateBuilder(args);



builder.Services.AddScoped<IEmployeeService, EmployeeService>();

var app = builder.Build();

// ����� ���� �������
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
// ����� �������
builder.Services.AddControllers();
builder.Services.AddSingleton<UserServices>(); // ����� ������



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