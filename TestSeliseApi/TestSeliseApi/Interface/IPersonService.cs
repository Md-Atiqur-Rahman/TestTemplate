using System.Collections.Generic;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;

namespace TestSeliseApi.Interface
{
    public interface IPersonService
    {
        List<PersonVm> GetAll(dbTestContext _dbContext);
        PersonVm GetPersonById(int id,dbTestContext _dbContext);
        PersonVm Add(PersonVm model, dbTestContext _dbContext);
    }
}
