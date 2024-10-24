﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class EpisodeRepository : IRepository<Episode>
    {
        Serializer<Episode> dataSerialize;
        List<Episode> listEpisodes;

        public EpisodeRepository()
        {
            dataSerialize = new Serializer<Episode>();
            listEpisodes = new List<Episode>();
            listEpisodes.GetAll();
        }
    }
}
