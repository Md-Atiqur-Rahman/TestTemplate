using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelise.Models.Models
{
    public class DocumentInfoVM
    {
        public int DocumentId { get; set; }
        public string TableName { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string FileType { get; set; }
        public string RecStatus { get; set; }
        public string OrgFileName { get; set; }
        public string UserId { get; set; }
        public int? ForeignKeyId { get; set; }
    }
}
