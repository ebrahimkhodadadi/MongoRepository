using Data.Mongo.Collections;
using Data.Mongo.Repo;
using Microsoft.AspNetCore.Mvc;

namespace MongoDBAspNetCore.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController : ControllerBase
{
    public HomeController(IMongoRepository<PersonDocument> personRepo)
    {

    }

    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}
