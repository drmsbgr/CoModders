using Entities;
using Entities.Dtos;

namespace Services.Contracts;

public interface IQuestionService
{
    IEnumerable<Question> GetAllQuestions(bool trackChanges);
    Question? GetQuestionById(int id, bool trackChanges);
    void CreateQuestion(QuestionDtoForInsertion questionDto);
    void UpdateQuestion(QuestionDtoForUpdate questionDto);
    void DeleteQuestionById(int id);
    QuestionDtoForUpdate GetQuestionByIdForUpdate(int id, bool trackChanges);
}