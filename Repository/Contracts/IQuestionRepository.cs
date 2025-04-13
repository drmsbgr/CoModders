using Entities;

namespace Repository.Contracts;

public interface IQuestionRepository : IRepositoryBase<Question>
{
    IQueryable<Question> GetAllQuestions(bool trackChanges);
    Question? GetQuestionById(int id, bool trackChanges);
    void CreateQuestion(Question question);
    void DeleteQuestion(Question question);
    void UpdateQuestion(Question question);
}
