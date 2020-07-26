using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ClassRoom
    {
        public int Id_ClassRoom { get; set; }
        public string ClassName { get; set; }
        public School School { get; set; }
    }
}
