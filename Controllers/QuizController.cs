using Microsoft.AspNetCore.Mvc;
using QuizzApp.Models;
using System.Collections.Generic;

namespace QuizzApp.Controllers
{
    public class QuizController : Controller
    {
        private static List<QuizQuestion> questions = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Id = 1,
                Question = "What is the capital of France?",
                Options = new[] { "Berlin", "Madrid", "Paris", "Lisbon" },
                CorrectOptionIndex = 2
            },
            new QuizQuestion
            {
                Id = 2,
                Question = "What is 2 + 2?",
                Options = new[] { "3", "4", "5", "6" },
                CorrectOptionIndex = 1
            },
            new QuizQuestion
            {
                Id = 3,
                Question = "What is the largest ocean on Earth?",
                Options = new[] { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" },
                CorrectOptionIndex = 3
            },
            new QuizQuestion
            {
                Id = 3,
                Question = "What is the longest river in India?",
                Options = new[] { "son", "Ganga", "Satluj", "saraswati" },
                CorrectOptionIndex = 1
            }
        };

        public IActionResult Index()
        {
            return View(questions);
        }

        [HttpPost]
        public IActionResult Submit(List<int> selectedOptions)
        {
            int score = 0;
            for (int i = 0; i < selectedOptions.Count; i++)
            {
                if (selectedOptions[i] == questions[i].CorrectOptionIndex)
                {
                    score++;
                }
            }
            ViewBag.Score = score;
            return View("Result");
        }
    }
}