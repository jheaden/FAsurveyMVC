using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQuizMVC.ViewModels;
using FAsurveyintoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using static FAsurveyintoMVC.Models.Lookups;

namespace FAsurveyintoMVC.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var QuestionCollection = new List<Question>();

            Question q1 = new Question("When I started to eat certain foods, I ate much more than planned.", Category.largerAmt, Frequency._4to6TimesAWeek);
            Question q2 = new Question("I continued to eat certain foods even though I was no longer hungry.", Category.largerAmt, Frequency._4to6TimesAWeek);
            Question q3 = new Question("I ate to the point where I felt physically ill.", Category.largerAmt, Frequency._2to3TimesaMonth);

            Question q4 = new Question("I worried a lot about cutting down on certain types of food, but I ate them anyways.", Category.cantQuit, Frequency._4to6TimesAWeek);
            Question q25 = new Question("I really wanted to cut down on or stop eating certain kinds of foods, but I just couldn’t.", Category.cantQuit, Frequency._4to6TimesAWeek);

            QuestionCollection.Add(q1);
            QuestionCollection.Add(q2);
            QuestionCollection.Add(q3);
            QuestionCollection.Add(q4);
            QuestionCollection.Add(q25);

            var model = new SurveyViewModel();
            model.Questions = QuestionCollection;

            return View(model);

        }

        [HttpPost]
        public IActionResult Index(SurveyViewModel model)
        {
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Test()
        {

            var model = new TestViewModel();
            model.Persons = new List<Person>();
            model.Persons.Add(new Person { Name = "Luke", Age = 36 });
            model.Persons.Add(new Person { Name = "Donkus", Age = 36 });

            return View(model);
        }

        [HttpPost]
        public IActionResult Test(TestViewModel model)
        {


            return RedirectToAction("Test");
        }

        public class TestViewModel
        {
            public List<Person> Persons { get; set; }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

    }
}