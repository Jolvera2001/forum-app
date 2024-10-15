namespace forumApp.Models;

public class Like
{
    public int Total { get; set; }
    
    public User User { get; set; }
    public Post Post { get; set; }
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
}