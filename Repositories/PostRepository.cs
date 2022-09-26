using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MVCPortfolio.Data;
using MVCPortfolio.Entities;

namespace MVCPortfolio.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ILogger<PostRepository> _logger;
    private readonly AppDbContext _context;

    public PostRepository(AppDbContext context, ILogger<PostRepository> logger)
    {
        _logger = logger;
        _context = context;
    }
    public async Task<Post> CreateAsync(Post post, string userId)
    {
        post.AppUserId = userId;
        var entity = await _context.Posts!.AddAsync(post);
        await _context.SaveChangesAsync();
        return entity.Entity;
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await GetPostAsync(id);
        if(entity == null) return;
        _context.Posts!.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Post> GetPostAsync(long id) => await _context.Posts!.FirstAsync(p => p.Id == id);

    public async Task<IEnumerable<Post>> GetPostsAsync(Expression<Func<Post, bool>> exp) => await _context.Posts!.Include(p => p.Author).Where(exp).ToListAsync();

    public async Task<Post> UpdateAsync(Post post)
    {
        var entity = _context.Posts!.Update(post);
        await _context.SaveChangesAsync();
        return entity.Entity;
    }
}