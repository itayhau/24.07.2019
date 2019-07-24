using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2407
{
    public class MainWIndowViewModel
    {

        public Person MyPerson1 { get; set; }

        public MainWIndowViewModel()
        {
            MyPerson1 = new Person() { Name = "Yakov Israel" };
            
        }
    }
}
