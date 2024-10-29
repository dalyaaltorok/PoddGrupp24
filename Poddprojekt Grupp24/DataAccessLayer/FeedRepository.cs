using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class FeedRepository : IRepository<Feed>
    {
        Serializer<Feed> serialize;
        List<Feed> feedList;
        public FeedRepository(String path)
        {
            serialize = new Serializer<Feed>(path);
            feedList = serialize.Deserialize();
            GetAll();
        }

        public Feed GetByName(String name)
        {
            foreach (var feed in feedList)
            {
                if (feed.Name == name)
                {
                    return feed;
                }
            }
            return null;
        }

        public List<Feed> GetAll()
        {
            return feedList;
        }

        public void Add(Feed feed)
        {
            if (GetByName(feed.Name) == null)
            {
                feedList.Add(feed);
                SaveAll();
            }
        }

        public void Update(Feed feed)
        {
            for (int i = 0; i < feedList.Count; i++)
            {
                if (feedList[i].Name == feed.Name)
                {
                    feedList[i] = feed;
                    SaveAll();
                    return;
                }
            }
        }
        public void Delete(int index)
        {
            feedList.RemoveAt(index);
            SaveAll();
        }

        public void SaveAll()
        {
            serialize.Serialize(feedList);
        }
    }
}
