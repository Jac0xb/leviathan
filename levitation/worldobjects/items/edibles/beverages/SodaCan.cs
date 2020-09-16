using levitation.worldobjects.traits;
using System;
using System.Timers;

namespace levitation.worldobjects.items.edibles
{
    class SodaCan: IEdible, ISmall, IShakable
    {
        readonly static string Name = "Soda";

        Tuple<int, string>[] Contents;
        private bool shook_ = false;
        private Timer shookTimer_;

        public void Consume(WorldObject obj)
        {

            if (obj is IConsumer)
            {
                IConsumer consumer = (IConsumer)obj;
                consumer.Consume(this);
            }

            throw new System.NotImplementedException();
        }

        public void Explode()
        {

        }

        public void Shake()
        {

            if (this.shook_) this.Explode();

            this.shookTimer_ = new Timer(30*1000);
            this.shookTimer_.Elapsed += (sender, e) => { this.shook_ = false; };
            this.shookTimer_.Start();
        }

        public bool isShook()
        {
            return true;
        }

    }
}
