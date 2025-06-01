using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    [Route("home")]
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string appTitle = "ASP.Net Core Development. Hello Guys";
            //ViewData["appTitle"] = appTitle;

            Person person = new Person
            {
                Name = "John Doe",
                BirthDate = Convert.ToDateTime("2000-01-01"),
                PersonGender = Gender.Male
                // BirthDate=null
            };
            //ViewData["person"] = person;


    List<Person>? people = new List<Person>
    {
        new Person { Name = "Ramjan", PersonGender = Gender.Male, BirthDate=Convert.ToDateTime("1/1/2001")},
        new Person { Name="Rahim",PersonGender=Gender.Male,BirthDate=Convert.ToDateTime("2/1/2001")}
    };
            //ViewData["people"] = people;
            ViewBag.people = people;

            return View(people);
        }
        [Route("person-details/{name}")]
        public IActionResult Details(string? name) {
            List<Person>? people = new List<Person>
    {
        new Person { Name = "Ramjan", PersonGender = Gender.Male, BirthDate=Convert.ToDateTime("1/1/2001")},
        new Person { Name="Rahim",PersonGender=Gender.Male,BirthDate=Convert.ToDateTime("2/1/2001")}
    };
           Person? matchingPerson= people.Where(p => p.Name == name).FirstOrDefault();
            if (matchingPerson == null)
            {
                return NotFound($"Person with name {name} not found.");
            }

            return View(matchingPerson);
        }
       
    }

}
