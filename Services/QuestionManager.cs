using Entities;
using AutoMapper;
using Entities.Dtos;
using Repository.Contracts;
using Services.Contracts;

namespace Services;

public class QuestionManager(IRepositoryManager manager, IMapper mapper) : IQuestionService
{
    private readonly IRepositoryManager _manager = manager;
    private readonly IMapper _mapper = mapper;

    public void CreateQuestion(QuestionDtoForInsertion questionDto)
    {
        var question = _mapper.Map<Question>(questionDto);
        _manager.QuestionRepo.CreateQuestion(question);
        _manager.Save();
    }

    public void DeleteQuestionById(int id)
    {
        var question = GetQuestionById(id, false);
        if (question is not null)
            _manager.QuestionRepo.DeleteQuestion(question);
        _manager.Save();
    }

    public IEnumerable<Question> GetAllQuestions(bool trackChanges)
    {
        return _manager.QuestionRepo.GetAllQuestions(trackChanges);
    }

    public Question? GetQuestionById(int id, bool trackChanges)
    {
        return _manager.QuestionRepo.GetQuestionById(id, trackChanges);
    }

    public QuestionDtoForUpdate GetQuestionByIdForUpdate(int id, bool trackChanges)
    {
        var question = GetQuestionById(id, trackChanges) ?? throw new Exception($"id:{id} -> Böyle bir soru bulunamadı!");
        var questionDto = _mapper.Map<QuestionDtoForUpdate>(question);
        return questionDto;
    }

    public void UpdateQuestion(QuestionDtoForUpdate questionDto)
    {
        var entity = _mapper.Map<Question>(questionDto);
        _manager.QuestionRepo.UpdateQuestion(entity);
        _manager.Save();
    }
}