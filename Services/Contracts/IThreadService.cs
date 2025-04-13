using Entities.Dtos.Thread;

namespace Services.Contracts;

public interface IThreadService
{
    IEnumerable<Entities.Thread> GetAllThreads(bool trackChanges);
    Entities.Thread? GetThreadById(int id, bool trackChanges);
    void CreateThread(ThreadDtoForInsertion threadDto);
    void UpdateThread(ThreadDtoForUpdate threadDto);
    void DeleteThreadById(int id);
    ThreadDtoForUpdate GetThreadByIdForUpdate(int id, bool trackChanges);
}