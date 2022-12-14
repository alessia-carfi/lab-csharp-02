using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class SocialNetworkUser<TUser> : User, ISocialNetworkUser<TUser>
        where TUser : IUser
    {
        private Dictionary<string, ISet<TUser>> _followers = new Dictionary<string, ISet<TUser>>();
        public SocialNetworkUser(string fullName, string username, uint? age) : base(fullName, username, age)
        {
            // throw new NotImplementedException("TODO is there anything to do here?");
        }

        public bool AddFollowedUser(string group, TUser user)
        {
            // throw new NotImplementedException("TODO add user to the provided group. Return false if the user was already in the group");
            if(!_followers.ContainsKey(group))
            {
                _followers[group] = new HashSet<TUser>();
                _followers[group].Add(user);
            }
            return _followers[group].Add(user);
        }

        public IList<TUser> FollowedUsers 
        {
            // throw new NotImplementedException("TODO construct and return the list of all users followed by the current users, in all groups");
            get {
                HashSet<TUser> followed = new HashSet<TUser>();
                foreach (var group in _followers.Values)
                {
                    foreach (var user in group)
                    {
                        followed.Add(user);
                    }
                }
                return new List<TUser>(followed);
            }
        }
        public ICollection<TUser> GetFollowedUsersInGroup(string group)
        {
            // throw new NotImplementedException("TODO construct and return a collection containing of all users followed by the current users, in group");
            return _followers.Where(item => item.Key.Equals(group))
                    .Select(item => item.Value)
                    .FirstOrDefault(new HashSet<TUser>());
        }
    }
}
