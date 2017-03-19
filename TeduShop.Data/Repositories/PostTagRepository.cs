using TeduShop.Data.Infratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {

    }
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}