using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IManageFactory
    {
        IEnumerable<IFactory> GetAllFactories();
        IEnumerable<IFactory> GetUserFactories(int userId);
        IFactory GetFactory(int id);
        bool AddFactory(IFactory factory);
        bool UpdateFactory(IFactory factory);
        bool Deletefactory(IFactory factory);
    }
}

