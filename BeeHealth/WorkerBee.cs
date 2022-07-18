
namespace BeeHealth
{
    sealed class WorkerBee : Bee
    {
        public WorkerBee() : base()
        { }

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (!this.Dead && this.Health <= 70)
            {
                this.Dead = true;
            }
        }
    }
}
