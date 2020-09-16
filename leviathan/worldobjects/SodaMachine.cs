using leviathan.worldobjects.items.tools;
using leviathan.worldobjects.traits;
using System;
using System.Collections.Generic;
namespace leviathan.worldobjects
{
    public class SodaMachine: WorldObject
    {
        public enum HackState
        {
            ExplodeOnPurchase,
            ShakeOnDispense,
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

            if (this.hackState == HackState.ShakeOnDispense && item is IShakable shakable)
            {
                shakable.Shake();
            }

            Engine.Spawn(item, localDispensePosition);
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

        public Stack<WorldObject> GetInventory()
        {
            return this.Inventory;
        }
    }

}
