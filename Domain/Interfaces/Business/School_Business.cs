using Domain.Business;
using Domain.Entities;
using Domain.Interfaces.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Business
{
    public class School_Business : ISchool_Business
    {
        private readonly ILogger _logger;
        private readonly ISchoolDAL _schoolDAL;

        public School_Business(ILogger logger, ISchoolDAL schoolDAL)
        {
            _logger = logger;
            _schoolDAL = schoolDAL;
        }

        public void InsertSchool(School school)
        {
            try
            {
                _schoolDAL.RegisterSchool(school);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error InsertSchool: {ex}");
            }
        }

        public List<School> ListSchools()
        {
            return _schoolDAL.ListSchool();
        }
    }
}
