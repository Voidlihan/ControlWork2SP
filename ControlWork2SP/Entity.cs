using System;

namespace ControlWork2SP
{
    abstract public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}