using levitation.worldobjects.traits;
using System;

namespace levitation.worldobjects.items.edibles
{
    class SodaCan: IEdible, ISmall
    {
        readonly static string Name = "Soda";

        Tuple<int, string>[] Contents;

        public void Consume(WorldObject obj)
        {

            if (obj is IConsumer)
            {
                IConsumer consumer = (IConsumer)obj;
                consumer.Consume(this);
            }

            throw new System.NotImplementedException();
        }
      
    }
}
