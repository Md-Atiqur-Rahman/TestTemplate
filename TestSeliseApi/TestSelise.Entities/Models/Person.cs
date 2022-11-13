using System;
using System.Collections.Generic;

#nullable disable

namespace TestSelise.Entities.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Photo { get; set; }
        public int? DivisionId { get; set; }
        public byte[] Photograph { get; set; }
    }
}
