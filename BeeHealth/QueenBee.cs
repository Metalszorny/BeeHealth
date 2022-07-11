
namespace BeeHealth
{
    class QueenBee : Bee
    {
        public QueenBee() : base()
        { }

        public override void Damage(int percent)
        {
            base.Damage(percent);

            if (!this.Dead && this.Health <= 20)
            {
                this.Dead = true;
            }
        }
    }
}
