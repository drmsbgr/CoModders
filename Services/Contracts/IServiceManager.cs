namespace Services.Contracts;

public interface IServiceManager
{
    IForumService ForumService { get; }
    IForumGroupService ForumGroupService { get; }
    IRuleService RuleService { get; }
    IQuestionService QuestionService { get; }
    IThreadService ThreadService { get; }
}