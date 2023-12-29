// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Riddles.Models;
using System;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    private List<Riddle> riddles = new List<Riddle>
    {

         new Riddle { Question = "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?", Answer = "Echo" },
         new Riddle { Question = "The more you feed it, the more it grows. What is it?", Answer = "Fire" },
         new Riddle { Question = "What has keys but can't open locks?", Answer = "Piano" },
         new Riddle { Question = "The person who makes it, sells it. The person who buys it never uses it. What is it?", Answer = "Coffin" },
         new Riddle { Question = "I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. What am I?", Answer = "Map" },
         new Riddle { Question = "I'm tall when I'm young, and short when I'm old. What am I?", Answer = "Candle" },
         new Riddle { Question = "The more you take, the more you leave behind. What am I?", Answer = "Footsteps" },
         new Riddle { Question = "What comes once in a minute, twice in a moment, but never in a thousand years?", Answer = "Letter 'M'" },
         new Riddle { Question = "I have keys but open no locks. I have space but no room. You can enter, but you can't go inside. What am I?", Answer = "Keyboard" },
         new Riddle { Question = "The one who makes it, sells it. The one who buys it never uses it. What is it?", Answer = "Coffin" }
        // Add more riddles as needed
    };

    [BindProperty]
    public List<string> Answers { get; set; }

    public List<Riddle> Riddles => riddles;

    public IActionResult OnPost()
    {
        // Calculate grade
        int correctAnswers = 0;
        for (int i = 0; i < riddles.Count; i++)
        {
            if (Answers[i].Trim().Equals(riddles[i].Answer, StringComparison.OrdinalIgnoreCase))
            {
                correctAnswers++;
            }
        }

        TempData["Grade"] = correctAnswers;

        return RedirectToPage("/Result");
    }



   
        public IActionResult OnGet()
        {
            return RedirectToPage("/Riddles");
        }
   
}
