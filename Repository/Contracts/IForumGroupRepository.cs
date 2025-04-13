using Entities;

namespace Repository.Contracts;

public interface IForumGroupRepository : IRepositoryBase<ForumGroup>
{
    IQueryable<ForumGroup> GetAllForumGroups(bool trackChanges);
    ForumGroup? GetForumGroupById(int id, bool trackChanges);
    void CreateForumGroup(ForumGroup forumGroup);
    void DeleteForumGroup(ForumGroup forumGroup);
    void UpdateForumGroup(ForumGroup forumGroup);
}