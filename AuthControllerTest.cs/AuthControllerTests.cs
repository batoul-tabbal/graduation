using System.Threading.Tasks;
using System.Threading.Tasks;
using grade.LogIn;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
[TestFixture]
public class AuthControllerTests
{
    private AuthControllerTests _controller;

    [SetUp]
    public void Setup()
    {
        _controller = new AuthControllerTests();
    }

    [Test]
    public async Task Login_ValidUser_ReturnsToken()
    {
        var user = new User { Username = "admin", Password = "password" };
        var result = await _controller.Login(user) as OkObjectResult;
        Assert.NotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var response = result.Value as LogInResponse;
        Assert.NotNull(response.Token);
    }

    private async Task<OkObjectResult> Login(User user)
    {
        throw new NotImplementedException();
    }

    [Test]
    public async Task Login_InvalidUser_ReturnsUnauthorized()
    {
        var user = new User { Username = "invalid", Password = "wrong_password" };
        var result = await _controller.Login(user);
        Assert.IsInstanceOf<UnauthorizedResult>(result);
    }
}