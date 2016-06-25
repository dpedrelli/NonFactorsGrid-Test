using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NonFactorsGrid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult NonFactorsSearch()
        {
            return PartialView("~/Views/Home/_AjaxGrid.cshtml", PeopleRepository.GetPeople());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class PersonModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }

        public Int32 Age { get; set; }
        public DateTime Birthday { get; set; }
        public Boolean? IsWorking { get; set; }

        public IList<PersonModel> Children { get; set; }
    }

    public static class PeopleRepository
    {
        public static IEnumerable<PersonModel> GetPeople(String search = "")
        {
            search = (search ?? "").ToLower();

            return new List<PersonModel>
            {
                new PersonModel
                {
                    Id = 1,
                    Name = "Joe",
                    Surname = "Crosswave",

                    Age = (Int32)(DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    Birthday = new DateTime(1988, 01, 05),
                    IsWorking = false,

                    Children = new List<PersonModel>
                    {
                        new PersonModel
                        {
                            Id = 11,
                            Name = "Katy",
                            Surname = "Crosswave",

                            Age = (Int32)(DateTime.Now - new DateTime(2015, 01, 05)).TotalDays / 365,
                            Birthday = new DateTime(2015, 01, 05)
                        },
                        new PersonModel
                        {
                            Id = 12,
                            Name = "Kate",
                            Surname = "Crosswave",

                            Age = (Int32)(DateTime.Now - new DateTime(2015, 01, 05)).TotalDays / 365,
                            Birthday = new DateTime(2015, 01, 05)
                        }
                    }
                },
                new PersonModel
                {
                    Id = 2,
                    Name = "Merry",
                    Surname = "Lisel",

                    Age = (Int32)(DateTime.Now - new DateTime(1978, 05, 06)).TotalDays / 365,
                    Birthday = new DateTime(1978, 05, 06),

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 3,
                    Name = "Henry",
                    Surname = "Crux",

                    Age = (Int32)(DateTime.Now - new DateTime(1990, 11, 19)).TotalDays / 365,
                    Birthday = new DateTime(1990, 11, 19),
                    IsWorking = true,

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 4,
                    Name = "Cody",
                    Surname = "Jurut",

                    Age = (Int32)(DateTime.Now - new DateTime(1970, 08, 11)).TotalDays / 365,
                    Birthday = new DateTime(1970, 08, 11),
                    IsWorking = false,

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 5,
                    Name = "Simon",
                    Surname = "Scranton",

                    Age = (Int32)(DateTime.Now - new DateTime(1985, 10, 10)).TotalDays / 365,
                    Birthday = new DateTime(1985, 10, 10),

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 6,
                    Name = "Leena",
                    Surname = "Laurent",

                    Age = (Int32)(DateTime.Now - new DateTime(2000, 07, 01)).TotalDays / 365,
                    Birthday = new DateTime(2000, 07, 01),
                    IsWorking = false,

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 7,
                    Name = "Ode",
                    Surname = "Cosmides",

                    Age = (Int32)(DateTime.Now - new DateTime(1966, 04, 17)).TotalDays / 365,
                    Birthday = new DateTime(1966, 04, 17),
                    IsWorking = true,

                    Children = new List<PersonModel>
                    {
                        new PersonModel
                        {
                            Id = 71,
                            Name = "Jake",
                            Surname = "Cosmides",

                            Age = (Int32)(DateTime.Now - new DateTime(2014, 07, 14)).TotalDays / 365,
                            Birthday = new DateTime(2014, 07, 14)
                        }
                    }
                },
                new PersonModel
                {
                    Id = 8,
                    Name = "Diandra",
                    Surname = "Mizner",

                    Age = (Int32)(DateTime.Now - new DateTime(1999, 08, 20)).TotalDays / 365,
                    Birthday = new DateTime(1999, 08, 20),
                    IsWorking = false,

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 9,
                    Name = "Pete",
                    Surname = "Cassel",

                    Age = (Int32)(DateTime.Now - new DateTime(1997, 03, 13)).TotalDays / 365,
                    Birthday = new DateTime(1997, 03, 13),
                    IsWorking = false,

                    Children = new List<PersonModel>()
                },
                new PersonModel
                {
                    Id = 10,
                    Name = "Nicky",
                    Surname = "Tremblay",

                    Age = (Int32)(DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    Birthday = new DateTime(1988, 01, 05),
                    IsWorking = true,

                    Children = new List<PersonModel>
                    {
                        new PersonModel
                        {
                            Id = 101,
                            Name = "Nick",
                            Surname = "Tremblay",

                            Age = (Int32)(DateTime.Now - new DateTime(2013, 06, 08)).TotalDays / 365,
                            Birthday = new DateTime(2013, 06, 08)
                        },
                        new PersonModel
                        {
                            Id = 102,
                            Name = "Nike",
                            Surname = "Tremblay",

                            Age = (Int32)(DateTime.Now - new DateTime(2014, 12, 12)).TotalDays / 365,
                            Birthday = new DateTime(2014, 12, 12)
                        },
                        new PersonModel
                        {
                            Id = 103,
                            Name = "Norbert",
                            Surname = "Tremblay",

                            Age = (Int32)(DateTime.Now - new DateTime(2015, 05, 23)).TotalDays / 365,
                            Birthday = new DateTime(2015, 05, 23)
                        }
                    }
                }
            }.Where(person =>
                    person.Age.ToString().Contains(search) ||
                    person.Name.ToLower().Contains(search) ||
                    person.Surname.ToLower().Contains(search) ||
                    person.Birthday.ToString().Contains(search))
            .ToList();
        }
    }

}
