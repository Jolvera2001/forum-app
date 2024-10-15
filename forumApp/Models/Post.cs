namespace forumApp.Models;

public class Post : BaseModel
{
    public string Title { get; set; }
    public string Content { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    
    public User User { get; set; }
    public Guid UserId { get; set; }
}