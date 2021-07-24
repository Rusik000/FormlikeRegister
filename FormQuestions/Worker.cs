using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuestions
{
    public class Worker:Human
    {

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Speciality { get; set; } = string.Empty;


        public string Department { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public List<string> Languages { get; set; }

    }
}
