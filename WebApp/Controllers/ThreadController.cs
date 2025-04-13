using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApp.Models;

namespace WebApp.Controllers;

public class ThreadController(ILogger<HomeController> logger, IServiceManager manager) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly IServiceManager _manager = manager;

    public IActionResult Index(int id)
    {
        var thread = _manager.ThreadService.GetAllThreads(false).AsQueryable().AsNoTracking().Include(r => r.Posts).FirstOrDefault(f => f.Id == id);

        if (thread is not null)
            return View(thread);
        else
            return Redirect("/Home/");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}