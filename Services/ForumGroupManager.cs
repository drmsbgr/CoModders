using Entities;
using AutoMapper;
using Entities.Dtos.ForumGroup;
using Repository.Contracts;
using Services.Contracts;

namespace Services;

public class ForumGroupManager(IRepositoryManager manager, IMapper mapper) : IForumGroupService
{
    private readonly IRepositoryManager _manager = manager;
    private readonly IMapper _mapper = mapper;

    public void CreateForumGroup(ForumGroupDtoForInsertion forumGroupDto)
    {
        var forumGroup = _mapper.Map<ForumGroup>(forumGroupDto);
        _manager.ForumGroupRepo.CreateForumGroup(forumGroup);
        _manager.Save();
    }

    public void DeleteForumGroupById(int id)
    {
        var forumGroup = GetForumGroupById(id, false);
        if (forumGroup is not null)
            _manager.ForumGroupRepo.DeleteForumGroup(forumGroup);
        _manager.Save();
    }

    public IEnumerable<ForumGroup> GetAllForumGroups(bool trackChanges)
    {
        return _manager.ForumGroupRepo.GetAllForumGroups(trackChanges);
    }

    public ForumGroup? GetForumGroupById(int id, bool trackChanges)
    {
        return _manager.ForumGroupRepo.GetForumGroupById(id, trackChanges);
    }

    public ForumGroupDtoForUpdate GetForumGroupByIdForUpdate(int id, bool trackChanges)
    {
        var forum = GetForumGroupById(id, trackChanges) ?? throw new Exception($"id:{id} -> Böyle bir forum grubu bulunamadı!");
        var forumGroupDto = _mapper.Map<ForumGroupDtoForUpdate>(forum);
        return forumGroupDto;
    }

    public void UpdateForumGroup(ForumGroupDtoForUpdate forumGroupDto)
    {
        var entity = _mapper.Map<ForumGroup>(forumGroupDto);
        _manager.ForumGroupRepo.UpdateForumGroup(entity);
        _manager.Save();
    }
}