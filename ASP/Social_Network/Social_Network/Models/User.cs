using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDay { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Country Countries { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }      
        public Gender Genders { get; set; }
        public bool Status { get; set; }
        public bool ConfirmedEmail { get; set; }
        public string StatusText { get; set; }
        public string ProfileImage { get; set; }
        public List<Like> Likes { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public Guid FriendId { get; set; }
        public UserFriend Friend { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Message> Messages { get; set; }
        public List<UserFriend> UserFriends { get; set; }
    }
}
