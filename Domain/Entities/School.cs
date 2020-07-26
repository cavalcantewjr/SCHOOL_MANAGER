using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Adress { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }

    }
}
