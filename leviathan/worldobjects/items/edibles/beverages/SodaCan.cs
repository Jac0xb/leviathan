using leviathan.worldobjects.traits;
using System;
using System.Timers;

namespace leviathan.worldobjects.items.edibles
{
    public class SodaCan: Item, IEdible, ISmall, IShakable
    {
        readonly static string Name = "Soda";

        Tuple<int, string>[] Contents;
        private bool shook_ = false;
        private Timer shookTimer_;

        public void Consume(WorldObject obj, ConsumptionTargetInfo info)
        {


            if (obj is IConsumer consumer)
            {
                consumer.Consume(this);
            }

            throw new NotImplementedException();
        }

        public void Explode()
        {

        }

        public void Shake()
        {

            if (this.shook_) this.Explode();
            if (this.shookTimer_ != null) this.shookTimer_.Dispose();

            this.shookTimer_ = new Timer(30*1000);
            this.shookTimer_.Elapsed += (sender, e) => { this.shook_ = false; };
            this.shookTimer_.Start();
        }

        public bool isShook()
        {
            return this.shook_;
        }

    }
}
