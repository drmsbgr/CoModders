using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController(ILogger<HomeController> logger, RepositoryContext context) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly RepositoryContext context = context;

    public IActionResult Index()
    {
        return View(context.ForumGroups.AsQueryable().AsNoTracking());
    }

    public IActionResult Rules()
    {
        return View(context.Rules.AsQueryable().AsNoTracking());
    }

    public IActionResult Faq()
    {
        return View(context.Questions.AsQueryable().AsNoTracking());
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Members()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
