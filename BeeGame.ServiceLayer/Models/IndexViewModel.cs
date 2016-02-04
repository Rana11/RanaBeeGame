namespace BeeGame.ServiceLayer.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        [UIHint("BeeViewModel")]
        public IList<BeeViewModel> QueenBees { get; set; }

        [UIHint("BeeViewModel")]
        public IList<BeeViewModel> WorkerBees { get; set; }

        [UIHint("BeeViewModel")]
        public IList<BeeViewModel> DroneBees { get; set; }
    }
}