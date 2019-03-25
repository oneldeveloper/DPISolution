using System;
using System.Collections.Generic;
using System.Text;

namespace DPILocalStorage
{
    interface IRepository<T>
    {
        bool Add(T Entity);
        bool Remove(T Entity);
        bool Update(T Entity);
    }
}
