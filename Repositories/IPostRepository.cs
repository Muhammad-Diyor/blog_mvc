using System.Linq.Expressions;
using MVCPortfolio.Entities;

namespace MVCPortfolio.Repositories;

public interface IPostRepository
{
    Task<Post> CreateAsync(Post post, string userId);
    Task<Post> GetPostAsync(long id);
    Task<IEnumerable<Post>> GetPostsAsync(Expression<Func<Post, bool>> exp);
    Task<Post> UpdateAsync(Post post);
    Task DeleteAsync(long id);
}