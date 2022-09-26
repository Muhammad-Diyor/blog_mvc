using MVCPortfolio.Models;

namespace MVCPortfolio.Services;

public interface IPostService
{
    Task<PostViewModel> CreatePostAsync(CreateOrUpdateViewModel model, string userId);
    Task<PostViewModel> UpdatePostAsync(long id, CreateOrUpdateViewModel model);
    Task<PostViewModel> GetPostAsync(long id);
    Task<IEnumerable<PostViewModel>> GetPostsAsync();
    Task DeletePostAsync(long id);
}