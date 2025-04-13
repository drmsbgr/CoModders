using Repository.Contracts;

namespace Repository;
public class RepositoryManager(RepositoryContext context, IForumRepository forumRepo, IForumGroupRepository forumGroupRepo, IQuestionRepository questionRepo, IRuleRepository ruleRepo, IThreadRepository threadRepo) : IRepositoryManager
{
    private readonly RepositoryContext _context = context;
    private readonly IForumRepository _forumRepo = forumRepo;
    private readonly IForumGroupRepository _forumGroupRepo = forumGroupRepo;
    private readonly IQuestionRepository _questionRepo = questionRepo;
    private readonly IRuleRepository _ruleRepo = ruleRepo;
    private readonly IThreadRepository _threadRepo = threadRepo;

    public IForumRepository ForumRepo => _forumRepo;
    public IForumGroupRepository ForumGroupRepo => _forumGroupRepo;
    public IQuestionRepository QuestionRepo => _questionRepo;
    public IRuleRepository RuleRepo => _ruleRepo;
    public IThreadRepository ThreadRepo => _threadRepo;

    public void Save()
    {
        _context.SaveChanges();
    }
}