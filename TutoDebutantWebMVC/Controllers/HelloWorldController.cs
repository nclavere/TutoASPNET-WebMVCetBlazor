using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TutoDebutantWebMVC.Controllers;
public class HelloWorldController : Controller
{
    // GET : /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }


    // GET : /HelloWorld/Bienvenue/
    public IActionResult Bienvenue(int id, string name="unknown", int nbFois = 1)
    {
        //return HtmlEncoder.Default.Encode($"Bonjour {name}, id:{id},  nb fois = {nbFois}"); ;

        ViewData["Message"] = "Bonjour " + HtmlEncoder.Default.Encode(name);
        ViewData["nbfois"] = nbFois;
        ViewData["id"] = id;

        return View();

    }
}
