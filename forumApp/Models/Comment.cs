namespace forumApp.Models;

public class Comment
{
    public string Content { get; set; }
    
    public User User { get; set; }
    public Post Post { get; set; }
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
}