using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelise.Models.Models
{
    public class PersonVm
    {
        public PersonVm()
        {
            DocumentInfos = new List<DocumentInfoVM>();
        }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photograph { get; set; }
        public string Photo { get; set; }
        public int? DivisionId { get; set; }
        public string DivisionName { get; set; }
        public List<DocumentInfoVM> DocumentInfos { get; set; }
    }
}
