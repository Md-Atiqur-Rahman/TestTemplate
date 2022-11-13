using System.Collections.Generic;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;

namespace TestSeliseApi.Interface
{
    public interface ICommonService
    {
        List<CommonCodeVM> GetAll(dbTestContext _db, string type);
        List<DocumentInfoVM> GetDocuments(DocumentInfoVM data, dbTestContext _db);
        bool SaveDoc(int PersonInfoId, List<DocumentInfoVM> model ,dbTestContext _db);
    }
}
