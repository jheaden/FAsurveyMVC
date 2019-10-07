﻿using FAsurveyintoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FAsurveyintoMVC.Models.Lookups;

namespace FAQuizMVC.ViewModels
{
    public class SurveyViewModel
    {
        public List<Question> Questions { get; set; }
        public List<int> Answers { get; set; }
    }
}
