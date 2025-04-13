using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApp.Models;

namespace WebApp.Controllers;

public class ForumController(ILogger<HomeController> logger, IServiceManager manager) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly IServiceManager _manager = manager;

    public IActionResult Index(int id)
    {
        var forum = _manager.ForumService.GetAllForums(false).AsQueryable().Include(r => r.Threads).FirstOrDefault(f => f.Id == id);

        if (forum is not null)
            return View(forum);
        else
            return Redirect("/Home/");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}