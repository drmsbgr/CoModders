using Entities;
using Entities.Dtos.Forum;

namespace Services.Contracts;

public interface IForumService
{
    IEnumerable<Forum> GetAllForums(bool trackChanges);
    Forum? GetForumById(int id, bool trackChanges);
    void CreateForum(ForumDtoForInsertion forum);
    void UpdateForum(ForumDtoForUpdate forum);
    void DeleteForumById(int id);
    ForumDtoForUpdate GetForumByIdForUpdate(int id, bool trackChanges);
}