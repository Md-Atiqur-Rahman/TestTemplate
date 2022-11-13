using System;
using System.Collections.Generic;
using System.Linq;
using TestSeliseApi.Interface;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;

namespace TestSeliseApi.Service
{
    public class CommonService : ICommonService
    {
        
       
        public List<CommonCodeVM> GetAll(dbTestContext _db,string type)
        {
            try
            {
                List<CommonCodeVM> commons = new List<CommonCodeVM>();
               var data = _db.CommonCodes.Where(x=>x.Type == type).ToList();
                foreach (var item in data)
                {
                    CommonCodeVM common = new CommonCodeVM();
                    common.CommonCodeId = item.CommonCodeId;
                    common.Name = item.Name;
                    commons.Add(common);
                }
                return commons;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }


        public bool SaveDoc( int PersonInfoId ,List<DocumentInfoVM> model, dbTestContext _db)
        {
            foreach (var item in model)
            {
                var entity = new DocumentInfo() {
                    ForeignKeyId = PersonInfoId,
                    FileLocation= item.FileLocation,
                    FileName = item.FileName,
                    //FileType = item.FileType,
                    //DocumentInfoId = item.DocumentId,
                    OrgFileName = item.OrgFileName,
                    RecStatus = "A",
                    TableName = "Person",
                    UserId= ""
                };
                var save = _db.DocumentInfos.Add(entity);
                _db.SaveChanges();
            }
            return true;
        }

        public List<DocumentInfoVM> GetDocuments(DocumentInfoVM data, dbTestContext _db)
        {
            List<DocumentInfoVM> list = new List<DocumentInfoVM>();
            var docs = _db.DocumentInfos.Where(x => x.ForeignKeyId == data.ForeignKeyId && x.TableName == data.TableName && x.RecStatus !="C");
            foreach (var item in docs)
            {
                DocumentInfoVM entity = new DocumentInfoVM();
                entity.FileLocation = item.FileLocation;
                entity.DocumentId = item.DocumentInfoId;
                entity.FileName = item.FileName;
                entity.OrgFileName = item.OrgFileName;
                entity.TableName = item.TableName;
                entity.ForeignKeyId = item.ForeignKeyId;
                list.Add(entity);
            }
            return list;
        }
    }
}
