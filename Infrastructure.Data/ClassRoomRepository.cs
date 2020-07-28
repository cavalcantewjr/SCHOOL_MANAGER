using Domain.Entities;
using Domain.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class ClassRoomRepository : IClassRoomDAL
    {
        public void DeleteSchool(int id)
        {
            using var db = new SchoolContext();
            {
                List<ClassRoom> classRooms = (List<ClassRoom>)db.ClassRooms.ToList().Where(b => b.Id_ClassRoom == id);
                foreach (var result in classRooms)
                {
                    db.ClassRooms.Remove(result);
                }
                db.SaveChanges();

            }
        }

        public List<ClassRoom> ListClass()
        {
            using var db = new SchoolContext();
            List<ClassRoom> classRooms = db.ClassRooms.ToList();
            return classRooms;
        }

        public List<ClassRoom> ListClassById(ClassRoom classRoom)
        {
            throw new NotImplementedException();
        }

        public void RegisterClass(ClassRoom classRoom)
        {
            using var db = new SchoolContext();
            db.ClassRooms.Add(classRoom);
            db.SaveChanges();
        }

        public void UpdateSchool(ClassRoom classRoom)
        {
            using var db = new SchoolContext();
            db.ClassRooms.Update(classRoom);
            db.SaveChanges();
        }
    }
}
