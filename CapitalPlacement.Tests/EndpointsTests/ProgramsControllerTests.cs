using AutoMapper;
using CapitalPlacement.Database;
using CapitalPlacement.Dtos.ProgramDetailDtos;
using CapitalPlacement.Endpoints;
using CapitalPlacement.Models;
using CapitalPlacement.Models.ProgramDetailModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Tests.EndpointsTests
{
    public class ProgramsControllerTests
    {
        public ProgramsControllerTests()
        {
            
        }

        [Fact]
        public async Task CreateProgram_ShouldBeSuccessful_WithValidValues()
        {
            // arrange
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<CreateProgramRequestDto, ProgramDetail>(It.IsAny<CreateProgramRequestDto>()))
                .Returns(It.IsAny<ProgramDetail>());

            var cosmosDbSetMock = new Mock<ICosmosDbSet<ProgramModel>>();
            cosmosDbSetMock.Setup(x => x.AddAsync(It.IsAny<ProgramModel>()))
                .Returns(Task.CompletedTask);

            var cosmosContextMock = new Mock<ICosmosContext>();
            cosmosContextMock.Setup(x => x.Programs.AddAsync(It.IsAny<ProgramModel>())).Returns(Task.CompletedTask);

            var controller = new ProgramsController(mapperMock.Object, cosmosContextMock.Object);

            var request = new CreateProgramRequestDto
            {
                Title = ""
            };

            // act
            var result = await controller.CreateProgram(request);

            // assert
            mapperMock.Verify(x => x.Map<ProgramDetail>(It.IsAny<CreateProgramRequestDto>()), Times.Once());

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task CreateProgram_ShouldReturnBadRequest_WithInvalidValues()
        {
            // arrange
            var request = new CreateProgramRequestDto
            {
                Title = "A title"
            };

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<CreateProgramRequestDto, ProgramDetail>(request))
                .Returns(new ProgramDetail { Title = request.Title });

            /*var cosmosDbSetMock = new Mock<ICosmosDbSet<ProgramModel>>();
            cosmosDbSetMock.Setup(x => x.AddAsync(It.IsAny<ProgramModel>()))
                .Returns(Task.CompletedTask);*/

            var cosmosContextMock = new Mock<ICosmosContext>();
            cosmosContextMock.Setup(x => x.Programs.AddAsync(It.IsAny<ProgramModel>())).Returns(Task.CompletedTask);

            var controller = new ProgramsController(mapperMock.Object, cosmosContextMock.Object);

            // act
            var result = await controller.CreateProgram(request);

            // assert
            var okObjectResult = Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
