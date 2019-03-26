using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
        /* This is the managin interface for factories
    Here are specified what the concrete class should do
    The concrete class should implement also the basic core rules
    to manage factories 
     */
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

