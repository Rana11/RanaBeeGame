namespace BeeGame.DomainLayer.Entities
{
    using System;

    public class QueenBee : Bee
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
                return 100;
            }
        }

        protected override int Deduction
        {
            get
            {
                return 8;
            }
        }

    }
}