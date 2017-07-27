using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Utilities
{
    class DataGeneator
    {
        public static string DateTimeBasedString()
        {
           return DateTime.Now.ToString("dd.MM.hh.mm.ss.f");
        }
    }
}
