using Services.Contracts;

namespace Services;

public class ServiceManager(IForumService forumService, IForumGroupService forumGroupService, IRuleService ruleService, IQuestionService questionService, IThreadService threadService) : IServiceManager
{
    private readonly IForumService _forumService = forumService;
    private readonly IForumGroupService _forumGroupService = forumGroupService;
    private readonly IRuleService _ruleService = ruleService;
    private readonly IQuestionService _questionService = questionService;
    private readonly IThreadService _threadService = threadService;
    public IForumService ForumService => _forumService;
    public IForumGroupService ForumGroupService => _forumGroupService;
    public IRuleService RuleService => _ruleService;
    public IQuestionService QuestionService => _questionService;
    public IThreadService ThreadService => _threadService;
}
