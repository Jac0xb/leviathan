using System;
using System.Collections.Generic;
using System.Text;

namespace levitation.worldobjects.items.edibles
{
    interface IEdible
    {
        void Consume(WorldObject obj);
    }
}
