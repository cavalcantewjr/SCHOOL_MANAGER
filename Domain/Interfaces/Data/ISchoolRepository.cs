using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Data
{
    public interface ISchoolRepository
    {
        public void RegisterSchool(School school);
        public List<School> ListSchool();
        public School ListSchoolById(int id);
        public void DeleteSchool(int id);
        public void UpdateSchool(School school);
    }
}
