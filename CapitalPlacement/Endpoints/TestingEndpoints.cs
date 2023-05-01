using Bogus;
using CapitalPlacement.Database;
using CapitalPlacement.Enums;
using CapitalPlacement.Models.ApplicationFormModels;
using CapitalPlacement.Models.ProgramDetailModels;
using CapitalPlacement.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Endpoints
{
    public class TestingEndpoints
    {
        private readonly ICosmosContext _context;
        private readonly IProgramService _programService;

        public TestingEndpoints(ICosmosContext context, IProgramService programService)
        {
            _context = context;
            _programService = programService;
        }

        public async Task AddProgram()
        {
            Console.WriteLine("Adding progrem");
            var programDetailFaker = new Faker<ProgramDetail>()
                .RuleFor(x => x.ApplicationClose, val => DateTime.UtcNow)
                .RuleFor(x => x.ApplicationOpen, val => DateTime.UtcNow)
                .RuleFor(x => x.ProgramStart, val => DateTime.UtcNow)
                .RuleFor(x => x.ApplicationCriteria, val => val.Lorem.Paragraph(1))
                .RuleFor(x => x.Summary, val => val.Lorem.Paragraph(1))
                .RuleFor(x => x.Description, val => val.Lorem.Paragraph(1))
                .RuleFor(x => x.Benefits, val => val.Lorem.Paragraph(1))
                .RuleFor(x => x.Duration, val => "6 months")
                .RuleFor(x => x.Skills, val => new[] { "Thinking" })
                .RuleFor(x => x.Title, val => val.Lorem.Text())
                .RuleFor(x => x.Type, val => ProgramType.Long)
                .RuleFor(x => x.MinQualification, val => Qualification.High_School)
                .RuleFor(x => x.MaxApplicationAllowed, val => val.Random.Int(1, 10000));

            var id = Guid.NewGuid().ToString();

            await _programService.CreateAsync(new()
            {
                Id = id,
                Detail = programDetailFaker.Generate(1)[0]
            });

            Console.WriteLine("Finished Adding progrem");
        }

        public async Task GetProgram()
        {
            var program = await _context.Programs.GetAsync("0a3ad493-a821-4c2d-a381-5ee7c0346134");
            Console.Write(JsonConvert.SerializeObject(program));
        }

        public async Task AddApplicationForm()
        {
            var applicationForm = new ApplicationForm
            {
                CoverImageUrl = "google.com",
                Id = "0a3ad493-a821-4c2d-a381-5ee7c0346134",
                ProgramId = "0a3ad493-a821-4c2d-a381-5ee7c0346134",
                PersonalInfo = new(),
                Profile = new()
            };

            await _context.ApplicationForms.AddAsync(applicationForm);
        }
    }
}
