
namespace BeeHealth
{
    sealed class DroneBee : Bee
    {
        public DroneBee() : base()
        { }

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (!this.Dead && this.Health <= 50)
            {
                this.Dead = true;
            }
        }
    }
}
