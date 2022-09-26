namespace MVCPortfolio.Models;

public class CreateOrUpdateViewModel
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public IFormFile? Image { get; set; }
}