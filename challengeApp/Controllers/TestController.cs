using challengeApp.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace challengeApp.Controllers;

[Controller]
[Route("api")]
public class TestController : ControllerBase
{
    private readonly ICodingChallenge _codingChallenge;

    public TestController(ICodingChallenge codingChallenge)
    {
        _codingChallenge = codingChallenge;
    }
    [HttpGet]
    public IActionResult TestEndpoint()
    {
        // trigger for our logic
        _codingChallenge.Init();
        return  Ok(" app is running ");
    }
}