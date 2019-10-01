using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FAsurveyintoMVC.Models.Lookups;

namespace FAsurveyintoMVC.Models
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
