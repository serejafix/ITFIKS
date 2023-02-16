using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Social_Network.Models
{
    public class UserFriend
    {
        public Guid MainUserId { get; set; }
        public Guid FriendUserId { get; set; }
        public User User { get; set; }
    }
}
