using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Data
{
    public interface IClassRoomDAL
    {
        public void RegisterClass(ClassRoom classRoom);
        public List<ClassRoom> ListClass();
        public List<ClassRoom> ListClassById(ClassRoom classRoom);
        public void DeleteSchool(int id);
        public void UpdateSchool(ClassRoom classRoom);
    }
}
