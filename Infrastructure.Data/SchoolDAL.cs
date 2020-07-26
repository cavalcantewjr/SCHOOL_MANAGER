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
    public class SchoolDAL : ISchoolDAL
    {
        public void DeleteSchool(int id)
        {
            using var db = new SchoolContext();
            {
                List<School> schools = (List<School>)db.Schools.ToList().Where(b => b.Id == id);
                foreach (var result in schools)
                {
                    db.Schools.Remove(result);
                }
                db.SaveChanges();

            }
        }

        public List<School> ListSchool()
        {
            using var db = new SchoolContext();
            List<School> schools = db.Schools.ToList();
            return schools;
        }

        //Listar por id. retorna o objeto conforme id no where
        //analisar melhor esse metodo
        public School ListSchoolById(int id)
        {
            using var db = new SchoolContext();
            var schools = (List<School>)db.Schools.ToList().Where(b => b.Id == id);
            School school = new School();
            school.Id = id;
            var result = db.Schools.Find(school.Id);
            return result;
        }

        public List<School> ListSchoolById(School school)
        {
            throw new NotImplementedException();
        }

        public void RegisterSchool(School school)
        {
            using var db = new SchoolContext();
            db.Schools.Add(school);
            db.SaveChanges();
        }

        public void UpdateSchool(School school)
        {
            using var db = new SchoolContext();
            db.Schools.Update(school);
            db.SaveChanges();
        }
    }
}
