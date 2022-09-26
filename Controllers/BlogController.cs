#pragma warning disable
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCPortfolio.Entities;
using MVCPortfolio.Models;
using MVCPortfolio.Services;

namespace MVCPortfolio.Controllers;


[Authorize]
public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;
    private readonly IPostService _service;
    private readonly UserManager<AppUser> _userManager;

    public BlogController(
        ILogger<BlogController> logger,
        IPostService service,
        UserManager<AppUser> userManager
    )
    {
        _logger = logger;
        _service = service;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var articl = await _service.GetPostsAsync();
        return View(articl);
    }
    public IActionResult Post() => View(new CreateOrUpdateViewModel());

    [HttpPost]
    public async Task<IActionResult> Post(CreateOrUpdateViewModel model)
    {
        if(!ModelState.IsValid) return View();
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        var post = await _service.CreatePostAsync(model, user.Id);
        return LocalRedirect($"/Blog/Article/{post.Id}");
    }

    public async Task<IActionResult> Article([FromRoute]long id)
    {
        var post = await _service.GetPostAsync(id);
        return View(post);
    }

}