using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi._2.Models
{
    public class AnimalArchive
    {
        public int id { get; set; }
        public int AnimalId { get; set; }
        public int Age { get; set; }
        public int LifeCycleId { get; set; }
        public int? PlayId { get; set; }
        public DateTime LastPlay { get; set; }
        public int? CleanId { get; set; }
        public DateTime? LastCleaned { get; set; }
        public int? FeedId { get; set; }
        public DateTime? LastFeed { get; set; }

    }
}
