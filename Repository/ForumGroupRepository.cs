using Entities;
using Repository.Contracts;

namespace Repository;

public class ForumGroupRepository(RepositoryContext context) : RepositoryBase<ForumGroup>(context), IForumGroupRepository
{
    public void CreateForumGroup(ForumGroup forumGroup) => Create(forumGroup);

    public void DeleteForumGroup(ForumGroup forumGroup) => Delete(forumGroup);

    public IQueryable<ForumGroup> GetAllForumGroups(bool trackChanges) => FindAll(trackChanges);

    public ForumGroup? GetForumGroupById(int id, bool trackChanges) => FindByCondition(x => x.Id == id, trackChanges);

    public void UpdateForumGroup(ForumGroup forumGroup) => Update(forumGroup);
}