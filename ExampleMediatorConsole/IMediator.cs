using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMediatorConsole
{
    public interface IMediator
    {

         void Send(string message, IColleague colleague);

    }
}
