﻿// Models/Question.cs
namespace QuizzApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string[] Options { get; set; }
        public string CorrectAnswer { get; set; }
    }
}