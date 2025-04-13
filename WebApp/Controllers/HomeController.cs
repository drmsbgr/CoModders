using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController(ILogger<HomeController> logger, IServiceManager manager) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly IServiceManager _manager = manager;

    public IActionResult Index()
    {
        var forumGroups = _manager.ForumGroupService.GetAllForumGroups(false).AsQueryable().AsNoTracking().Include(r => r.Forums).Where(x => x.Id > 2);
        var otherGroups = _manager.ForumGroupService.GetAllForumGroups(false).AsQueryable().AsNoTracking().Include(r => r.Forums).Where(x => x.Id <= 2);

        var allGroups = forumGroups.ToList();
        allGroups.AddRange(otherGroups);

        return View(allGroups.AsQueryable());
    }

    public IActionResult Rules()
    {
        return View(_manager.RuleService.GetAllRules(false).AsQueryable().AsNoTracking());
    }

    public IActionResult Faq()
    {
        return View(_manager.QuestionService.GetAllQuestions(false).AsQueryable().AsNoTracking());
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
