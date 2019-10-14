using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FAQuizMVC.Models.Lookups;

namespace FAQuizMVC.Models
{
    public class Question
    {
        public string Content;
        public Category Category;
        public Frequency Frequency;

        public Question(string content, Category category, Frequency freq)
        {
            Content = content;
            Category = category;
            Frequency = freq;
        }
    }
}
