using Microsoft.AspNetCore.Mvc;

namespace Lectrure2.Controllers;

public class BookController : Controller
{
    private Dictionary<int, FormBoook> books = new()
    {
        { 1, new FormBoook() { Author = "Freeman", Title = "C#", Id = 1 } },
        { 2, new FormBoook() { Author = "Bloch", Title = "Java", Id = 2 } },
        { 3, new FormBoook() { Author = "Freeman", Title = "JavaScript", Id = 3 } },
    };
    // GET
    public IActionResult Index()
    {
        return View(books);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        return View("Add", books[id]);
    }
    
    [HttpPost]
    public IActionResult Add(FormBoook book)
    {
        if (ModelState.IsValid)
        {
            return View("ConfirmBook", book);
        }
        else
        {
            return View();
        }
    }
    
    [HttpPost]
    public IActionResult Edit(FormBoook book)
    {
        if (ModelState.IsValid)
        {
            return View("ConfirmBook", book);
        }
        else
        {
            return View();
        }
    }

    public IActionResult Delete(int id)
    {
        books.Remove(id);
        return View("Index", books);
    }
}