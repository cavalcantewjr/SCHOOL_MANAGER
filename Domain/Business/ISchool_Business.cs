using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public interface ISchool_Business
    {
        void InsertSchool(School school);
        List<School> ListSchools();
    }
}
