namespace forumApp.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    
    public ICollection<Topic> Topics { get; set; } = new List<Topic>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Post> Posts { get; set; } = new List<Post>();

}