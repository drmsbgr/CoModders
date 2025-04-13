using AutoMapper;
using Repository.Contracts;
using Services.Contracts;
using Entities.Dtos.Thread;

namespace Services;

public class ThreadManager(IRepositoryManager manager, IMapper mapper) : IThreadService
{
    private readonly IRepositoryManager _manager = manager;
    private readonly IMapper _mapper = mapper;

    public void CreateThread(ThreadDtoForInsertion threadDto)
    {
        var thread = _mapper.Map<Entities.Thread>(threadDto);
        _manager.ThreadRepo.CreateThread(thread);
        _manager.Save();
    }

    public void DeleteThreadById(int id)
    {
        var question = GetThreadById(id, false);
        if (question is not null)
            _manager.ThreadRepo.DeleteThread(question);
        _manager.Save();
    }

    public IEnumerable<Entities.Thread> GetAllThreads(bool trackChanges)
    {
        return _manager.ThreadRepo.GetAllThreads(trackChanges);
    }

    public Entities.Thread? GetThreadById(int id, bool trackChanges)
    {
        return _manager.ThreadRepo.GetThreadById(id, trackChanges);
    }

    public ThreadDtoForUpdate GetThreadByIdForUpdate(int id, bool trackChanges)
    {
        var thread = GetThreadById(id, trackChanges) ?? throw new Exception($"id:{id} -> Böyle bir konu bulunamadı!");
        var threadDto = _mapper.Map<ThreadDtoForUpdate>(thread);
        return threadDto;
    }

    public void UpdateThread(ThreadDtoForUpdate threadDto)
    {
        var entity = _mapper.Map<Entities.Thread>(threadDto);
        _manager.ThreadRepo.UpdateThread(entity);
        _manager.Save();
    }
}