﻿using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public int SeasonCount { get; set; }
        public int EpisodeCount { get
            {
                return Episodes.Count;
            }
        }
        public double AverageRunTime { get
            {
                // double totalRunTime
                // for each episode
                //      add runTime to total
                // divide total by count
                double totalRunTime = 0;
                foreach(Episode episode in Episodes)
                {
                    totalRunTime += episode.RunTime;
                }
                return totalRunTime / EpisodeCount;

                //Fancy way with Linq
                // return Episodes.Select(e => e.RunTime).Sum() / EpisodeCount;
            }
        }

        // Modify this code so that we always get the right number of episodes. Right now its possible for EpisodeCount to have the wrong number
    }

    public class Episode
    {
        public string Title { get; set; }

        public double RunTime { get; set; }

        public int SeasonNumber { get; set; }
    }
}
