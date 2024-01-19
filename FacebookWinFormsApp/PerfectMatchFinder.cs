using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class PerfectMatchFinder
    {
        public Dictionary<string, int> FindPerfectMatch(User i_LoggedInUser)
        {
            if (i_LoggedInUser != null)
            {
                Dictionary<string, int> matchScores = new Dictionary<string, int>();

                foreach (User friend in i_LoggedInUser.Friends)
                {
                    int matchScore = calculateMatchScore(i_LoggedInUser, friend);
                    matchScores.Add(friend.Name, matchScore);
                }

                Dictionary<string, int> rankedFriends = matchScores.OrderByDescending(x => x.Value)
                                                                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                return rankedFriends;
            }

            return new Dictionary<string, int>();
        }

        private int calculateMatchScore(User user, User friend)
        {
            List<string> userLikes = getUserLikes(user);
            List<string> friendLikes = getUserLikes(friend);

            List<string> commonLikes = userLikes.Intersect(friendLikes).ToList();

            int weight = commonLikes.Count;

            return weight;
        }

        private List<string> getUserLikes(User user)
        {
            List<string> likes = user.LikedPages.Select(page => page.Name)
                                               .Union(user.Groups.Select(group => group.Name))
                                               .ToList();

            return likes;
        }
    }
}
