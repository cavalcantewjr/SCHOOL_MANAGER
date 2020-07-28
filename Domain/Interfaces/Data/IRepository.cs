using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Data
{
    public interface IRepository<T>
    {
        public void RegisterSchool(T item);
        public List<T> ListSchool();
    }
}
