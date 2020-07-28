using Domain.Entities;
using Domain.Interfaces.Data;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Data
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolContext _schoolContext;

        public SchoolRepository(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public void DeleteSchool(int id)
        {
            _schoolContext.Schools.Remove(ListSchoolById(id));
            _schoolContext.SaveChanges();
        }

        public List<School> ListSchool()
        {
            return _schoolContext.Schools.ToList(); ;
        }

        public School ListSchoolById(int id)
        {
            return _schoolContext.Schools.Where(school => school.IdEscola == id).FirstOrDefault();
        }

        public void RegisterSchool(School school)
        {
            _schoolContext.Schools.Add(school);
            _schoolContext.SaveChanges();
        }

        public void UpdateSchool(School school)
        {
            _schoolContext.Schools.Update(school);
            _schoolContext.SaveChanges();
        }
    }
}
