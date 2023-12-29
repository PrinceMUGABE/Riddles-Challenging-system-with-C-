using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Riddles.Pages
{
    public class ResultModel : PageModel
    {
        private int CalculateGrade(List<string> answers)
        {
        
            int correctAnswers = 0;

            
            int totalQuestions = 10;

            return (correctAnswers * 10) / totalQuestions; 
        }

        public IActionResult OnGet()
        {
            // Retrieve the actual correct answers from TempData
            int correctAnswers = (int)TempData["Grade"];

            // For demonstration purposes, let's assume you have 10 questions
            int totalQuestions = 10;

            TempData["Grade"] = (correctAnswers * 10) / totalQuestions;

            return Page();
        }

        

    }
}
