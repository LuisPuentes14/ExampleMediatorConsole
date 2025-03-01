﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMediatorConsole
{
    public class Mediator : IMediator
    {
        private List<IColleague> colleagues;
        public Mediator()
        {
            this.colleagues = new List<IColleague>();
        }

        public void Add(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        public void Send(string message, IColleague colleague)
        {
            foreach (var c in this.colleagues)
            {
                if (colleague != c)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
