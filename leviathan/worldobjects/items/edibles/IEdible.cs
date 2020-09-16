using System;
using System.Collections.Generic;
using System.Text;

namespace leviathan.worldobjects.items.edibles
{
    interface IEdible
    {
        void Consume(WorldObject obj, ConsumptionTargetInfo info);
    }
}
