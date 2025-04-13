using Entities;

namespace Repository.Contracts;

public interface IRuleRepository : IRepositoryBase<Rule>
{
    IQueryable<Rule> GetAllRules(bool trackChanges);
    Rule? GetRuleById(int id, bool trackChanges);
    void CreateRule(Rule rule);
    void DeleteRule(Rule rule);
    void UpdateRule(Rule rule);
}