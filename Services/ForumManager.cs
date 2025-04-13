using Entities;
using AutoMapper;
using Entities.Dtos.Forum;
using Repository.Contracts;
using Services.Contracts;

namespace Services;

public class ForumManager(IRepositoryManager manager, IMapper mapper) : IForumService
{
    private readonly IRepositoryManager _manager = manager;
    private readonly IMapper _mapper = mapper;

    public void CreateForum(ForumDtoForInsertion forumDto)
    {
        var forum = _mapper.Map<Forum>(forumDto);
        _manager.ForumRepo.CreateForum(forum);
        _manager.Save();
    }

    public void DeleteForumById(int id)
    {
        var forum = GetForumById(id, false);
        if (forum is not null)
            _manager.ForumRepo.DeleteForum(forum);
        _manager.Save();
    }

    public IEnumerable<Forum> GetAllForums(bool trackChanges)
    {
        return _manager.ForumRepo.GetAllForums(trackChanges);
    }

    public Forum? GetForumById(int id, bool trackChanges)
    {
        return _manager.ForumRepo.GetForumById(id, trackChanges);
    }

    public ForumDtoForUpdate GetForumByIdForUpdate(int id, bool trackChanges)
    {
        var forum = GetForumById(id, trackChanges) ?? throw new Exception($"id:{id} -> Böyle bir forum bulunamadı!");
        var forumDto = _mapper.Map<ForumDtoForUpdate>(forum);
        return forumDto;
    }

    public void UpdateForum(ForumDtoForUpdate forumDto)
    {
        var entity = _mapper.Map<Forum>(forumDto);
        _manager.ForumRepo.UpdateForum(entity);
        _manager.Save();
    }
}