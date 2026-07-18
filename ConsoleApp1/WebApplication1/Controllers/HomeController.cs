using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Diagnostics;
using WebApplication1.Models;
using static System.Net.WebRequestMethods;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Short Biography"] = "Hello! My name is Manzano Alejandro L. I am a passionate tech enthusiast who enjoys problem-solving, building functional desktop utilities, and working with backend logic. I have always been fascinated by how software classes and structural logic come together to create desktop solutions that process data efficiently.";
        ViewData["Educational Background"] = "I completed my previous academic schooling and graduated from Laguna Northwestern College. Building upon that, I am currently a 3rd-year college student pursuing my bachelor's degree in Information Technology. Across my current subjects, I am studying how to build web portfolios using APIs and classes, while concurrently learning the basics of desktop application development through Visual Basic in another dedicated programming course.";
        ViewData["Career Goals"] = "My primary career goal is to transition from academic logic into industry experience by securing an internship or entry-level position as a Software Developer or Application Programmer. Building on my studies in Visual Basic and class logic, I aim to focus heavily on translating system specifications into clean, interactive, and optimized desktop portfolio structures.";
        ViewData["Personal Interests"] = "When I am away from my development environment and school assignments, I enjoy exploring object-oriented programming challenges, learning about software optimization trends, and spending my free time playing computer video games with friends.";
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Design"] = "Structuring user-friendly application views and organizing logical dashboard interfaces.";
        ViewData["Troubleshooting"] = "Tracking down syntax bugs, resolving compile-time system errors, and debugging class data flows.";
        ViewData["Problem Solving"] = "Breaking down complex programming constraints into manageable, executable algorithms.";
        ViewData["Analytical thinker"] = "evaluating how independent backend APIs and application classes interact with data source layers.";
        return View();
    }

    public IActionResult Project()
    {
        ViewData["Discount"] = "A backend database management application constructed to process membership tiers, regular savings logic, and operational markdown parameters efficiently.";
        ViewData["Login System"] = "A desktop Windows Forms application built with Visual Basic designed to manage student allowance processing, interactive loan requests, and personalized funding balances.";
        ViewData["Parking System"] = "A Python-based desktop application utilizing CustomTkinter to automate real-time slot tracking, floor management, entry/exit timestamp logs, and error-free payment calculations.";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Email"] = "andrewmanzano000gmail.com";
        ViewData["Number"] = "09XX XXXX XXX";
        ViewData["Github"] = "https://github.com/andrewmanzano";
        ViewData["Linkedin"] = "https://linkedin.com";
        ViewData["Facebook"] = "https://facebook.com";
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}