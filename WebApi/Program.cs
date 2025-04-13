using Entities;
using Entities.Dtos;
using Entities.Dtos.Forum;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repository;
using Repository.Contracts;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Co-Modders API",
        Description = "An ASP.NET Core Web API for managing Co-Modders website",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Buğra DURMUŞ",
            Email = "drmsbgr@gmail.com"
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("WebApi"));
});

//repo
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IForumRepository, ForumRepository>();
builder.Services.AddScoped<IForumGroupRepository, ForumGroupRepository>();
builder.Services.AddScoped<IRuleRepository, RuleRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();

//services
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IForumService, ForumManager>();
builder.Services.AddScoped<IForumGroupService, ForumGroupManager>();
builder.Services.AddScoped<IRuleService, RuleManager>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();


builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api/forums", (IServiceManager _manager) =>
{
    return _manager.ForumService.GetAllForums(false);
})
.WithDisplayName("Get Forums")
.WithTags("Forum-CRUD")
.Produces<IEnumerable<Forum>>();

app.MapPost("/api/forums", (ForumDtoForInsertion instertionDto, IServiceManager _manager) =>
{
    _manager.ForumService.CreateForum(instertionDto);
})
.WithDisplayName("Create Forum")
.WithTags("Forum-CRUD");

app.MapPut("/api/forums", (ForumDtoForUpdate updateDto, IServiceManager _manager) =>
{
    _manager.ForumService.UpdateForum(updateDto);
})
.WithDisplayName("Update Forum")
.WithTags("Forum-CRUD");

app.MapDelete("/api/forums", (int id, IServiceManager _manager) =>
{
    _manager.ForumService.DeleteForumById(id);
})
.WithDisplayName("Delete Forum")
.WithTags("Forum-CRUD");

app.Run();
