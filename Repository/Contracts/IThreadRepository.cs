namespace Repository.Contracts;

public interface IThreadRepository : IRepositoryBase<Entities.Thread>
{
    IQueryable<Entities.Thread> GetAllThreads(bool trackChanges);
    Entities.Thread? GetThreadById(int id, bool trackChanges);
    void CreateThread(Entities.Thread thread);
    void DeleteThread(Entities.Thread thread);
    void UpdateThread(Entities.Thread thread);
}