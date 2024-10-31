using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using Models;
using DataAccessLayer;


namespace BusinessLayer
{
    /*
    public class FeedController
    {
        IRepository<Feed> feedRepository;
        SyndicationFeed stream;

        public FeedController(string path)
        {
            feedRepository = new FeedRepository(path);

        }

        public async Task CreateFeed(string name, string rss, Category category)
        {
            await GetRSSFeed(rss);
            string title = stream.Title.Text;
            List<Episode> episodes = new List<Episode>();
            foreach (SyndicationItem item in stream.Items)
            {
                Episode episode = new Episode(item.Title.Text, item.Summary.Text);
                episodes.Add(episode);
            }
            Feed newFeed = new Feed(name, title, category, episodes);
            feedRepository.Add(newFeed);

        }

        public List<Feed> GetFeeds()
        {
            return feedRepository.GetAll();
        }

        public void DeleteFeed(int index)
        {
            feedRepository.Delete(index);
        }

        public async Task GetRSSFeed(string rss)
        {
            Serializer<Feed> feedSerializer = new Serializer<Feed>();
            stream = await feedSerializer.DeserializeRSS(rss);
        }

        public Feed getFeed(string name)
        {
            return feedRepository.GetByName(name);
        }

        public void UpdateFeedName(int index, Feed feed, string newName)
        {
            feed.Name = newName;
            feedRepository.Update(feed, index);
        }

        public void updateFeedCategory(int index, Feed feed, Category category)
        {
            feed.Category = category;
            feedRepository.Update(feed, index);
        }
    }*/
}



































