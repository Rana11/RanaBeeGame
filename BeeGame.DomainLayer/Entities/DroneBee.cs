namespace BeeGame.DomainLayer.Entities
{
    using System;

    public class DroneBee : Bee
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
                return 50;
            }
        }

        protected override int Deduction
        {
            get
            {
                return 12;
            }
        }
    }
}