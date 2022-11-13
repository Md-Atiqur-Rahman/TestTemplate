using System.Collections.Generic;
using TestApplication.Models;
using TestSelise.Models.Models;

namespace TestApplication.ViewModels
{
    public class PersonRelatedInfoVm
    {
        public PersonRelatedInfoVm()
        {
            person = new PersonVm();
            persons = new List<PersonVm>();
            commonVm = new Common();
        }
        public PersonVm person { get; set; }
        public List<PersonVm> persons { get; set; }
        public Common commonVm { get; set; }
    }
}
