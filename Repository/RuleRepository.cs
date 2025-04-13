using Entities;
using Repository.Contracts;

namespace Repository;

public class RuleRepository(RepositoryContext context) : RepositoryBase<Rule>(context), IRuleRepository
{
    public void CreateRule(Rule rule) => Create(rule);

    public void DeleteRule(Rule rule) => Delete(rule);

    public IQueryable<Rule> GetAllRules(bool trackChanges) => FindAll(trackChanges);

    public Rule? GetRuleById(int id, bool trackChanges) => FindByCondition(x => x.Id == id, trackChanges);
    public void UpdateRule(Rule rule) => Update(rule);
}
