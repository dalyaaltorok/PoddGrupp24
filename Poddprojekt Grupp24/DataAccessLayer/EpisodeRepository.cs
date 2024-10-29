using System;
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

        public EpisodeRepository(string path)
        {
            dataSerialize = new Serializer<Episode>(path);
            listEpisodes = dataSerialize.Deserialize();
            GetAll();
        }

        public List<Episode> GetAll()
        {
            return listEpisodes;
        }

        public Episode GetByName(String name)
        {
            foreach (var episode in listEpisodes)
            {
                if (episode.Name == name)
                {
                    return episode;
                }
            }
            return null;
        }

        public void Add(Episode episode)
        {
            listEpisodes.Add(episode);
            SaveAll();        }

        public void Update(Episode episode)
        {
            for (int i = 0; i < listEpisodes.Count; i++)
            {
                if (listEpisodes[i].Name == episode.Name)
                {
                    listEpisodes[i] = episode;
                    SaveAll();
                    return;
                }
            }
        }

        public void Delete(int index)
        {
            listEpisodes.RemoveAt(index);
            SaveAll();
        }

        public void SaveAll()
        {
            dataSerialize.Serialize(listEpisodes);
        }
    }
}

