namespace forumApp.Models;

public class Topic
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public User User { get; set; }
    public Guid UserId { get; set; }
    
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}