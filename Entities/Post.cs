using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPortfolio.Entities;

public class Post
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Image { get; set; }
    public string? AppUserId { get; set; }

    [ForeignKey(nameof(AppUserId))]
    public AppUser? Author { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsEdited { get; set; } = false;
}