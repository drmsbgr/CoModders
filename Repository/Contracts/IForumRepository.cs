using Entities;

namespace Repository.Contracts;

public interface IForumRepository : IRepositoryBase<Forum>
{
    IQueryable<Forum> GetAllForums(bool trackChanges);
    Forum? GetForumById(int id, bool trackChanges);
    void CreateForum(Forum forum);
    void DeleteForum(Forum forum);
    void UpdateForum(Forum forum);
}