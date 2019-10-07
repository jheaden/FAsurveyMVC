using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQuizMVC.ViewModels
{
    public class TestViewModel
    {
        public TestViewModel()
        {
            Test = new List<string>();
        }
        public List<string> Test { get; set; }
    }
}
