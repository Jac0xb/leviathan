using System;
using System.Collections.Generic;
using System.Text;

namespace leviathan.worldobjects.traits
{
    public interface IConsumer: IWorldObject
    {
        void Consume(IWorldObject consumable);
    }
}
