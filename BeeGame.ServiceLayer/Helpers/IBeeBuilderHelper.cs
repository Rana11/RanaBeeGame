namespace BeeGame.ServiceLayer.Helpers
{
    using System.Collections.Generic;

    using BeeGame.DomainLayer.Entities;

    //interface needed for testing purposes

    public interface IBeeBuilderHelper
    {
        int RanadomNumber(int upperLimit);

        IList<Bee> GetListOfBees();
    }
}