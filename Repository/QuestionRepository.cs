using Entities;
using Repository.Contracts;

namespace Repository;

public class QuestionRepository(RepositoryContext context) : RepositoryBase<Question>(context), IQuestionRepository
{
    public void CreateQuestion(Question question) => Create(question);

    public void DeleteQuestion(Question question) => Delete(question);

    public IQueryable<Question> GetAllQuestions(bool trackChanges) => FindAll(trackChanges);

    public Question? GetQuestionById(int id, bool trackChanges) => FindByCondition(x => x.Id == id, trackChanges);
    public void UpdateQuestion(Question question) => Update(question);
}
