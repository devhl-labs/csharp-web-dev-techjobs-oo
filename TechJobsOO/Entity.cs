using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class Entity
    {
        public int Id { get; }

        private static int _nextId = 1;

        public Entity()
        {
            Id = _nextId;

            _nextId++;
        }
    }
}
