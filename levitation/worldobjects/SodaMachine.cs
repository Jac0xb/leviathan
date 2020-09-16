using levitation.worldobjects.items.tools;
using levitation.worldobjects.traits;
using System;
using System.Collections.Generic;
namespace levitation.worldobjects
{
    class SodaMachine: WorldObject
    {
        public enum HackState
        {
            ExplodeOnPurchase,
            ShakeSoda,
            ShootCans
        }

        readonly static Tuple<double, double, double> localDispensePosition = new Tuple<double, double, double>(0, 0, 0);
        readonly Stack<WorldObject> Inventory;

        private HackState? hackState = null;
        private bool Opened = false;

        public SodaMachine()
        {

        }

        public bool Insert(WorldObject obj)
        {

            if (obj is ISmall)
            {
                Inventory.Push(obj);
                return true;
            }

            return false;

        }

        public void Dispense() {

            if (Inventory.Count == 0) return;

            WorldObject item = Inventory.Pop();

            if (this.hackState == HackState.ExplodeOnPurchase)
            {

            }

            Engine.Spawn(, localDispensePosition);
        }


        public bool Open(WorldObject envoker)
        {
            if (envoker is ScrewDriver && !this.Opened)
            {
                this.Opened = true;
                return true;
            }

            return false;
        }

        public bool Close(WorldObject envoker)
        {
            if (envoker is ScrewDriver && this.Opened)
            {
                this.Opened = false;
                return true;
            }

            return false;
        }

        public void Hack(WorldObject envoker, HackState state)
        {

        }
    }

}
