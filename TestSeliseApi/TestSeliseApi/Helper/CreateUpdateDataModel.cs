using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSeliseApi.Helper
{
    public class CreateUpdateDataModel<T>
    {
        public T Data { get; set; }
        public List<T> ListData { get; set; }
    }
}
