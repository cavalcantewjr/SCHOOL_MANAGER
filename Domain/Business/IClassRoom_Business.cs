using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public interface IClassRoom_Business
    {
        void RegisterClassRoom(ClassRoom classRoom);
        List<ClassRoom> ListClassRooms(School school);
    }
}
