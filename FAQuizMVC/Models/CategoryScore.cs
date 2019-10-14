using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQuizMVC.Models
{
    public class CategoryScore
    {
        public int Category;
        public bool Significant;

        public CategoryScore(int category, bool signif)
        {
            Category = category;
            Significant = signif;
        }
    }
}
