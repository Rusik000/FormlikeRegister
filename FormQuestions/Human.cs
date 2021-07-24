using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuestions
{
    public abstract  class Human:UniqueID
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Gender { get; set; }

        public  string GetFullName() => $"{Name} {Surname}";

    }
}
