using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Data
{
    public interface ISchoolDAL
    {
        public void RegisterSchool(School school);
        public List<School> ListSchool();
        public List<School> ListSchoolById(School school);
        public void DeleteSchool(int id);
        public void UpdateSchool(School school);
    }
}
