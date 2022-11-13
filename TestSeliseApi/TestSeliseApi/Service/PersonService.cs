using System;
using System.Collections.Generic;
using System.Linq;
using TestSeliseApi.Interface;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;

namespace TestSeliseApi.Service
{
    public class PersonService : IPersonService
    {
        
        public PersonVm Add(PersonVm model, dbTestContext _dbContext)
        {
            try
            {
                var entity = new Person()
                {
                    PersonName = model.PersonName,
                    Address = model.Address,
                    DateOfBirth = model.DateOfBirth,
                    DivisionId = model.DivisionId,
                    Photograph = model.Photograph,
                };
                var save = _dbContext.People.Add(entity);
                _dbContext.SaveChanges();
                model.PersonId = entity.PersonId;
                return model;
            }
            catch (Exception ex)
            {
                return null;
            }
            return model;
        }

        public List<PersonVm> GetAll(dbTestContext _db)
        {
            try
            {
                List<PersonVm> persons = new List<PersonVm>();
               var data = _db.People.ToList();
                foreach (var item in data)
                {
                    PersonVm person = new PersonVm();
                    person.PersonName = item.PersonName;
                    person.Address = item.Address;
                    person.PersonId = item.PersonId;
                    persons.Add(person);
                }
                return persons;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public PersonVm GetPersonById(int id, dbTestContext _dbContext)
        {
            var data = _dbContext.People.FirstOrDefault(x => x.PersonId == id);
            PersonVm entity = new PersonVm();
            entity.PersonName = data.PersonName;
            entity.Address = data.Address;
            entity.DateOfBirth = data.DateOfBirth;
            entity.DivisionId = data.DivisionId;
            entity.Photograph = data.Photograph;
            var division = _dbContext.CommonCodes.FirstOrDefault(x => x.CommonCodeId == data.DivisionId);
            if (division != null)
                entity.DivisionName = division.Name;

            
            return entity;
        }
    }
}
