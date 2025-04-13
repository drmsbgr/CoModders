using Entities;
using Entities.Dtos.ForumGroup;

namespace Services.Contracts;

public interface IForumGroupService
{
    IEnumerable<ForumGroup> GetAllForumGroups(bool trackChanges);
    ForumGroup? GetForumGroupById(int id, bool trackChanges);
    void CreateForumGroup(ForumGroupDtoForInsertion forumGroup);
    void UpdateForumGroup(ForumGroupDtoForUpdate forumGroup);
    void DeleteForumGroupById(int id);
    ForumGroupDtoForUpdate GetForumGroupByIdForUpdate(int id, bool trackChanges);
}