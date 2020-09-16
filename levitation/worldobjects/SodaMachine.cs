using levitation.worldobjects.traits;
using System;
using System.Collections.Generic;
namespace levitation.worldobjects
{
    class SodaMachine: WorldObject
    {

        readonly static Tuple<double, double, double> localDispensePosition;
        readonly Stack<WorldObject> Inventory;

        public void Insert(WorldObject obj)
        {

            if (obj is ISmall)
            {
                Inventory.Push(obj);
            }

        }

        public void Dispense() {

            if (Inventory.Count == 0) return;

            Engine.Spawn(Inventory.Pop(), localDispensePosition);
        }
    }
}
