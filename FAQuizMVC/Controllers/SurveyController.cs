using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQuizMVC.ViewModels;
using FAQuizMVC.Models;
using Microsoft.AspNetCore.Mvc;
using FAQuizMVC.Services;
using static FAQuizMVC.Models.Lookups;

namespace FAsurveyintoMVC.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new SurveyViewModel();
            model.Questions = QuestionService.GetQuestions();

            return View(model);

        }

        [HttpPost]
        public IActionResult Index(SurveyViewModel model)
        {
            //get the questions for comparing threshold with answer to compute score
            var questions = QuestionService.GetQuestions();

            //array of booleans: total number of TRUE values in array = final score
            var categories = questions.GroupBy(q => q.Category).ToList();

            bool[] scoreCategories = new bool[categories.Count];

            //
            for (int j = 0; j < model.Answers.Count; j++)
            {
                var answer = model.Answers[j];
                var question = questions[j];

                if(answer >= (int)question.Frequency)
                {
                    scoreCategories[(int)questions[j].Category] = true;
                }

            }

            int tempScore = 0;
            foreach (var item in scoreCategories)
            {
                if (item == true)
                {
                    tempScore++;
                }
            }

            var resultViewModel = new ResultsViewModel();
            resultViewModel.Score = tempScore;

            //calculate and display diagnosis
            if (tempScore <= 1)
            {
                resultViewModel.Diagnosis = "No Food Addiction = 1 or fewer symptoms. Does not meet criteria for clinical significance.";
            }
            else if ((tempScore >= 2) && (tempScore < 4))
            {
                resultViewModel.Diagnosis = "Mild Food Addiction = 2 or 3 symptoms and clinical significance.";
            }
            else if ((tempScore >= 4) && (tempScore <= 5))
            {
                resultViewModel.Diagnosis = "Moderate Food Addiction = 4 or 5 symptoms and clinical significance";
            }
            else if (tempScore > 5)
            {
                resultViewModel.Diagnosis = "Severe Food Addiction = 6 or more symptoms and clinical significance";
            }


            return View("Result", resultViewModel);
            //return RedirectToAction("Result"); //change this.

        }

        [HttpGet]
        public IActionResult Result()
        {
            var model = new ResultsViewModel();
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