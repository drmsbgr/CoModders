using Entities;
using Repository.Contracts;

namespace Repository;

public class ForumRepository(RepositoryContext context) : RepositoryBase<Forum>(context), IForumRepository
{
    public void CreateForum(Forum forum) => Create(forum);

    public void DeleteForum(Forum forum) => Delete(forum);

    public IQueryable<Forum> GetAllForums(bool trackChanges) => FindAll(trackChanges);

    public Forum? GetForumById(int id, bool trackChanges) => FindByCondition(x => x.Id == id, trackChanges);
    public void UpdateForum(Forum forum) => Update(forum);
}
