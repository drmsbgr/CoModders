using Entities;
using Entities.Dtos;

namespace Services.Contracts;

public interface IRuleService
{
    IEnumerable<Rule> GetAllRules(bool trackChanges);
    Rule? GetRuleById(int id, bool trackChanges);
    void CreateRule(RuleDtoForInsertion ruleDto);
    void UpdateRule(RuleDtoForUpdate ruleDto);
    void DeleteRuleById(int id);
    RuleDtoForUpdate GetRuleByIdForUpdate(int id, bool trackChanges);
}
