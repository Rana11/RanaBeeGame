namespace BeeGame.ServiceLayer.Helpers
{
    using System;
    using System.Collections.Generic;
    using BeeGame.DomainLayer.Entities;

    public class BeeBuilderHelper : IBeeBuilderHelper
    {
        private const int NoOfQueens = 1;
        private const int NoOfWorkers = 5;
        private const int NoOfDrones = 8;

        public int RanadomNumber(int upperLimit)
        {
            var random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            return random.Next(0, upperLimit); // creates a number between 0 and upperlimit
        }

        public IList<Bee> GetListOfBees()
        {
            var beesList = new List<Bee>();

            for (var i = 0; i < NoOfQueens; i++)
            {
                beesList.Add(new QueenBee());
            }
            for (var i = 0; i < NoOfWorkers; i++)
            {
                beesList.Add(new WorkerBee());
            }

            for (var i = 0; i < NoOfDrones; i++)
            {
                beesList.Add(new DroneBee());
            }

            return beesList;
        }
    }
}