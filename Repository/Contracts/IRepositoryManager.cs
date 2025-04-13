namespace Repository.Contracts;

public interface IRepositoryManager
{
    IForumRepository ForumRepo { get; }
    IForumGroupRepository ForumGroupRepo { get; }
    IQuestionRepository QuestionRepo { get; }
    IRuleRepository RuleRepo { get; }
    IThreadRepository ThreadRepo { get; }
    void Save();
}