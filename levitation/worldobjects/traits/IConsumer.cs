using System;
using System.Collections.Generic;
using System.Text;

namespace levitation.worldobjects.traits
{
    public interface IConsumer: IWorldObject
    {
        void Consume(IWorldObject consumable);
    }
}
