namespace BeeGame.DomainLayer.Entities
{
    using System;

    public class WorkerBee : Bee
    {
        public override Type Type
        {
            get
            {
                return this.GetType();
            }
        }

        protected override int Points
        {
            get
            {
                return 75;
            }
        }

        protected override int Deduction
        {
            get
            {
                return 10;
            }
        }
    }
}