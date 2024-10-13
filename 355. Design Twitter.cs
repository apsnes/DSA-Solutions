public class Twitter {

    Dictionary<int, PriorityQueue<int, int>> feed;
    Dictionary<int, List<(int, int)>> tweets;
    Dictionary<int, HashSet<int>> followers = new();
    int count = 0;

    public Twitter() {
        this.feed = new();
        this.tweets = new();
    }
    
    public void PostTweet(int userId, int tweetId)
    {
        if (tweets.ContainsKey(userId))
        {
            List<(int, int)> currentUserAccount = tweets[userId];
            currentUserAccount.Add((count, tweetId));
        }
        else
        {
            List<(int, int)> currentUserAccount = new();
            currentUserAccount.Add((count, tweetId));
            tweets[userId] = currentUserAccount;
        }
        count++;
    }
    
    public IList<int> GetNewsFeed(int userId) {
        if (!followers.ContainsKey(userId))
        {
            HashSet<int> follows = new();
            follows.Add(userId);
            followers[userId] = follows;            
        }
        HashSet<int> currFollows = followers[userId];

        //iterate through tweets to find users that are in follow list. Add all to priority queue ordered by count.
        if (!feed.ContainsKey(userId))
        {
            feed[userId] = new PriorityQueue<int, int>();
        }      
        PriorityQueue<int, int> currFeed = feed[userId];

        foreach (int account in currFollows)
        {
            if (!tweets.ContainsKey(account))
            {
                continue;
            }
            List<(int, int)> currTweets = tweets[account];
            foreach ((int, int) pair in currTweets)
            {   
                currFeed.Enqueue(pair.Item2, 0 - pair.Item1);
            }
        }
        IList<int> res = new List<int>();
        //pop first 10 tweets in pq
            
        while (res.Count < 10 && currFeed.Count > 0)
        {
            int current = currFeed.Dequeue();
            if (res.Contains(current))
            {
                continue;
            }
            res.Add(current);
        }
        currFeed.Clear();
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (followers.ContainsKey(followerId))
        {
            HashSet<int> follows = followers[followerId];
            follows.Add(followeeId);
        }
        else
        {
            HashSet<int> follows = new();
            follows.Add(followeeId);
            follows.Add(followerId);
            followers[followerId] = follows;
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (followers.ContainsKey(followerId))
        {
            HashSet<int> follows = followers[followerId];
            follows.Remove(followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
