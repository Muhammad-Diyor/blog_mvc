namespace MVCPortfolio.Models;

public class PostViewModel
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Image { get; set; }
    public string? AppUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsEdited { get; set; }
    public string? AppUserPhoto { get; set; }
    public string? AppUserName { get; set; }
    
    
    
    
}