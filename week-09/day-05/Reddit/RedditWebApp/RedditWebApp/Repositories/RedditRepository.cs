﻿using RedditWebApp.Entities;
using RedditWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RedditWebApp.Repositories
{
    public class RedditRepository
    {
        RedditContext RedditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.RedditContext = redditContext;
        }

        public List<Reddit> GetList()
        {
            var listOfReddit = (from reddits in RedditContext.Reddits
                                orderby reddits.Score descending
                                select reddits).ToList();

            return listOfReddit;
        }

        public void Vote(string direction, int id)
        {
            var votedItem = (from votedOne in RedditContext.Reddits
                             where votedOne.Id == id
                             select votedOne).FirstOrDefault();

            if (direction.Equals("up"))
            {
                votedItem.Score++;
            }
            else if (direction.Equals("down"))
            {
                votedItem.Score--;
            }

            RedditContext.Update(votedItem);
            RedditContext.SaveChanges();
        }

        public void AddReddit(string content)
        {
            var myReddit = new Reddit()
            {
                Content = content
            };

            RedditContext.Add(myReddit);
            RedditContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteItem = (from deleteOne in RedditContext.Reddits
                              where deleteOne.Id == id
                              select deleteOne).FirstOrDefault();

            RedditContext.Remove(deleteItem);
            RedditContext.SaveChanges();
        }
    }
}
