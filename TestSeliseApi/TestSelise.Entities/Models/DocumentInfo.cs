using System;
using System.Collections.Generic;

#nullable disable

namespace TestSelise.Entities.Models
{
    public partial class DocumentInfo
    {
        public int DocumentInfoId { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string FileType { get; set; }
        public string RecStatus { get; set; }
        public string OrgFileName { get; set; }
        public string UserId { get; set; }
        public string TableName { get; set; }
        public int ForeignKeyId { get; set; }
    }
}
