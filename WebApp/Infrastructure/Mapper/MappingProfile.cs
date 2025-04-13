using AutoMapper;
using Entities;
using Entities.Dtos;
using Entities.Dtos.Forum;
using Entities.Dtos.ForumGroup;
using Entities.Dtos.Thread;

namespace WebApp.Infrastructure.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ForumDtoForInsertion, Forum>();
        CreateMap<ForumDtoForUpdate, Forum>().ReverseMap();

        CreateMap<ForumGroupDtoForInsertion, ForumGroup>();
        CreateMap<ForumGroupDtoForUpdate, ForumGroup>().ReverseMap();

        CreateMap<RuleDtoForInsertion, Rule>();
        CreateMap<RuleDtoForUpdate, Rule>().ReverseMap();

        CreateMap<QuestionDtoForInsertion, Question>();
        CreateMap<QuestionDtoForUpdate, Question>().ReverseMap();

        CreateMap<ThreadDtoForInsertion, Entities.Thread>();
        CreateMap<ThreadDtoForUpdate, Entities.Thread>().ReverseMap();
    }
}