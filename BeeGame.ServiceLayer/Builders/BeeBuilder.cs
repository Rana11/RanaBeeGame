using System.Collections.Generic;
using System.Linq;
using BeeGame.DomainLayer.Entities;
using BeeGame.ServiceLayer.Helpers;
using BeeGame.ServiceLayer.Models;

namespace BeeGame.ServiceLayer.Builders
{
    public class BeeBuilder
    {
        private static IList<Bee> bees;

        private IBeeBuilderHelper BeeBuilderHelper { get; set; }

        public BeeBuilder()
        {
            BeeBuilderHelper = new BeeBuilderHelper();
        }


        //this constructor needed for testing purposes
        public BeeBuilder(IBeeBuilderHelper beeBuilderHelper)
        {
            BeeBuilderHelper = beeBuilderHelper;
        }

        public IndexViewModel Build()
        {
            bees = BeeBuilderHelper.GetListOfBees();
            var beesViewModel =
                bees.Select(
                    (x, index) => new BeeViewModel { Id = index, Type = x.Type, PointsLeft = x.PointsLeft}).ToList();

            return new IndexViewModel
                       {
                           QueenBees = beesViewModel.Where(x => x.Type == typeof(QueenBee)).ToList(),
                           WorkerBees = beesViewModel.Where(x => x.Type == typeof(WorkerBee)).ToList(),
                           DroneBees = beesViewModel.Where(x => x.Type == typeof(DroneBee)).ToList()
                       };

        }

        public PostViewModel Hit()
        {
            var randomNumber = BeeBuilderHelper.RanadomNumber(bees.Count);

            var selectedBee = bees[randomNumber];

            selectedBee.Hit();

            if (selectedBee.IsDead)
            {
                bees.RemoveAt(randomNumber);
            }

            return new PostViewModel
                       {
                           id = randomNumber,
                           isFinish = IsFinish(),
                           isDead = selectedBee.IsDead,
                           pointsLeft = selectedBee.PointsLeft
                       };
        }

        private static bool IsFinish()
        {
            return !bees.Any() || bees.All(x => x.Type != typeof(QueenBee));
        }
    }
}
