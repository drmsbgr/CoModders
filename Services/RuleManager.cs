using Entities;
using AutoMapper;
using Entities.Dtos;
using Repository.Contracts;
using Services.Contracts;

namespace Services;

public class RuleManager(IRepositoryManager manager, IMapper mapper) : IRuleService
{
    private readonly IRepositoryManager _manager = manager;
    private readonly IMapper _mapper = mapper;

    public void CreateRule(RuleDtoForInsertion ruleDto)
    {
        var rule = _mapper.Map<Rule>(ruleDto);
        _manager.RuleRepo.CreateRule(rule);
        _manager.Save();
    }

    public void DeleteRuleById(int id)
    {
        var rule = GetRuleById(id, false);
        if (rule is not null)
            _manager.RuleRepo.DeleteRule(rule);
        _manager.Save();
    }

    public IEnumerable<Rule> GetAllRules(bool trackChanges)
    {
        return _manager.RuleRepo.GetAllRules(trackChanges);
    }

    public Rule? GetRuleById(int id, bool trackChanges)
    {
        return _manager.RuleRepo.GetRuleById(id, trackChanges);
    }

    public RuleDtoForUpdate GetRuleByIdForUpdate(int id, bool trackChanges)
    {
        var rule = GetRuleById(id, trackChanges) ?? throw new Exception($"id:{id} -> Böyle bir kural bulunamadı!");
        var ruleDto = _mapper.Map<RuleDtoForUpdate>(rule);
        return ruleDto;
    }

    public void UpdateRule(RuleDtoForUpdate ruleDto)
    {
        var entity = _mapper.Map<Rule>(ruleDto);
        _manager.RuleRepo.UpdateRule(entity);
        _manager.Save();
    }
}