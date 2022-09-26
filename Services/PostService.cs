using Microsoft.AspNetCore.Identity;
using MVCPortfolio.Entities;
using MVCPortfolio.Mappers;
using MVCPortfolio.Models;
using MVCPortfolio.Repositories;

namespace MVCPortfolio.Services;


public class PostService : IPostService
{
    private readonly ILogger<PostService> _logger;
    private readonly IPostRepository _repo;
    private readonly UserManager<AppUser> _userManager;

    public PostService(
        ILogger<PostService> logger,
        IPostRepository repo,
        UserManager<AppUser> userManager
    )
    {
        _logger = logger;
        _repo = repo;
        _userManager = userManager;
    }
    
    public async Task<PostViewModel> CreatePostAsync(CreateOrUpdateViewModel model, string userId)
    {
        var entity = await _repo.CreateAsync(model.ToEntity(), userId);
        return entity.ToModel();
    }

    public async Task DeletePostAsync(long id)
    {
        await _repo.DeleteAsync(id);
    }

    public async Task<PostViewModel> GetPostAsync(long id)
    {
        var post = await _repo.GetPostAsync(id);
        return post.ToModel();
    }

    public async Task<IEnumerable<PostViewModel>> GetPostsAsync()
    {
        var posts = await _repo.GetPostsAsync(p => true);
        return posts.Select(p => p.ToModel());
    }

    public async Task<PostViewModel> UpdatePostAsync(long id, CreateOrUpdateViewModel model)
    {
        var entity = await _repo.GetPostAsync(id);
        entity.Content = model.Content;
        entity.Title = model.Title;
        entity.Image = ModelEntityMapper.ToBase64String(model.Image!);
        entity.UpdatedDate = DateTime.Now;
        entity.IsEdited = true;
        return entity.ToModel();
    }
}