using AutoMapper;
using RickLocalization.Application.Commands.DimensionsTravelled.Add;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Interfaces.UoW;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RickLocalization.Test.Commands.DimensionsTravelled
{

    public class AddDimensionTravelledTest
    {
        private readonly IRickRepository _rickRepository;
        private readonly IDimensionRepository _dimensionRepository;
        private readonly IDimensionTravelledRepository _dimensionTravelledRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddDimensionTravelledTest(IRickRepository rickRepository, IDimensionRepository dimensionRepository, IDimensionTravelledRepository dimensionTravelledRepository, IUnitOfWork unitOfWork)
        {
            _rickRepository = rickRepository;
            _dimensionRepository = dimensionRepository;
            _dimensionTravelledRepository = dimensionTravelledRepository;
            _unitOfWork = unitOfWork;
        }

        [Fact]
        public async Task CommandIsValid_Executed_With_Success()
        {
            // Arrange
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AddInputModelToDimensionTravelledMapping());
            });
            var mapper = mockMapper.CreateMapper();

            var addDimensionTravelledCommand = new AddDimensionTravelledInputModel
            {
                idDimension = Guid.Parse("6f140d90-accb-4f19-8808-a22916a26d23"),
                idRick = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4")
            };

            var addDimensionTravelledCommandHandler = new AddDimensionTravelledCommandHandler(
                _dimensionTravelledRepository,
                _rickRepository,
                _dimensionRepository,
                mapper,
                _unitOfWork
             );

            // Act
            var dimensionTravelledResult = await addDimensionTravelledCommandHandler.Handle(addDimensionTravelledCommand, new System.Threading.CancellationToken());

            // Assert
            Assert.True(dimensionTravelledResult.success);

        }

        [Fact]
        public async Task CommandIsInvalid_DimensionNotExists()
        {
            // Arrange
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AddInputModelToDimensionTravelledMapping());
            });
            var mapper = mockMapper.CreateMapper();

            var addDimensionTravelledCommand = new AddDimensionTravelledInputModel
            {
                idDimension = Guid.Parse("32e9b5e2-b730-4b1e-b1ac-af94776a13cc"),
                idRick = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4")
            };

            var addDimensionTravelledCommandHandler = new AddDimensionTravelledCommandHandler(
                _dimensionTravelledRepository,
                _rickRepository,
                _dimensionRepository,
                mapper,
                _unitOfWork
             );

            // Act
            var dimensionTravelledResult = await addDimensionTravelledCommandHandler.Handle(addDimensionTravelledCommand, new System.Threading.CancellationToken());

            // Assert
            Assert.True(dimensionTravelledResult.success);

        }

        [Fact]
        public async Task CommandIsInvalid_RickNotExists()
        {
            // Arrange
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AddInputModelToDimensionTravelledMapping());
            });
            var mapper = mockMapper.CreateMapper();

            var addDimensionTravelledCommand = new AddDimensionTravelledInputModel
            {
                idDimension = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"),
                idRick = Guid.Parse("704b71f1-a782-4624-9b35-f92a843aa97b")
            };

            var addDimensionTravelledCommandHandler = new AddDimensionTravelledCommandHandler(
                _dimensionTravelledRepository,
                _rickRepository,
                _dimensionRepository,
                mapper,
                _unitOfWork
             );

            // Act
            var dimensionTravelledResult = await addDimensionTravelledCommandHandler.Handle(addDimensionTravelledCommand, new System.Threading.CancellationToken());

            // Assert
            Assert.True(dimensionTravelledResult.success);

        }

        [Fact]
        public async Task CommandIsInvalid_DimensionIsEquals_The_LastDimensionTravelled()
        {
            // Arrange
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AddInputModelToDimensionTravelledMapping());
            });
            var mapper = mockMapper.CreateMapper();

            var addDimensionTravelledCommand = new AddDimensionTravelledInputModel
            {
                idDimension = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"),
                idRick = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4")
            };

            var addDimensionTravelledCommandHandler = new AddDimensionTravelledCommandHandler(
                _dimensionTravelledRepository,
                _rickRepository,
                _dimensionRepository,
                mapper,
                _unitOfWork
             );

            // Act
            var dimensionTravelledResult = await addDimensionTravelledCommandHandler.Handle(addDimensionTravelledCommand, new System.Threading.CancellationToken());

            // Assert
            Assert.True(dimensionTravelledResult.success);

        }

    }
}
