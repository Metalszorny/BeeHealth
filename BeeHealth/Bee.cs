
namespace BeeHealth
{
    abstract class Bee
    {
        public Bee()
        {
            this.Health = 100;
            this.Type = this.GetType().Name;
        }

        public float Health { get; protected set; }
        public bool Dead { get; protected set; }
        public string Type { get; }

        public virtual void Damage(int percent)
        {
            if (this.Dead)
            {
                return;
            }
			
            if (percent < 0)
            {
                percent = 0;
            }
			
            if (percent > 100)
            {
                percent = 100;
            }

            this.Health -= (this.Health * (percent / (float)100));
        }
    }
}
