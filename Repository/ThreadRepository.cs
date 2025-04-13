using Entities;
using Repository.Contracts;

namespace Repository;

public class ThreadRepository(RepositoryContext context) : RepositoryBase<Entities.Thread>(context), IThreadRepository
{
    public void CreateThread(Entities.Thread thread) => Create(thread);

    public void DeleteThread(Entities.Thread thread) => Delete(thread);

    public IQueryable<Entities.Thread> GetAllThreads(bool trackChanges) => FindAll(trackChanges);

    public Entities.Thread? GetThreadById(int id, bool trackChanges) => FindByCondition(x => x.Id == id, trackChanges);
    public void UpdateThread(Entities.Thread thread) => Update(thread);
}
