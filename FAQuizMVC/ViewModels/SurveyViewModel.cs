using FAsurveyintoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQuizMVC.ViewModels
{
    public class SurveyViewModel
    {
        public List<Question> Questions { get; set; }
    }
}
