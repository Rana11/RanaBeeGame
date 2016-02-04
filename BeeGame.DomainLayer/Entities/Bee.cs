using System;

namespace BeeGame.DomainLayer.Entities
{
    public abstract class Bee
    {
        public abstract Type Type { get; }

        protected abstract int Points { get; }

        protected abstract int Deduction { get; }

        public virtual int PointsLeft { get; set; }

        public virtual bool IsDead
        {
            get
            {
                return this.PointsLeft == 0;
            }
        }

        protected Bee()
        {
            this.PointsLeft = this.Points;
        }

        public virtual void Hit()
        {
            this.PointsLeft = this.Deduction < this.PointsLeft ? this.PointsLeft - this.Deduction : 0;
        }

    }
}