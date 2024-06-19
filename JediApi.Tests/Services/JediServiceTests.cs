using JediApi.Models;
using JediApi.Repositories;
using JediApi.Services;
using Moq;

namespace JediApi.Tests.Services
{
    public class JediServiceTests
    {
        // não mexer
        private readonly JediService _service;
        private readonly Mock<IJediRepository> _repositoryMock;

        public JediServiceTests()
        {
            // não mexer
            _repositoryMock = new Mock<IJediRepository>();
            _service = new JediService(_repositoryMock.Object);
        }

        [Fact]
        public async Task GetById_Success()
        {
            var jedi = new jedi { Id = 1, Name = "VinicinDoMal", Strength = 100, Version = 1 };
            _repositoryMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(jedi);

            var result = await _service.GetByIdAsync(1);

            Assert.Equal(1, result.Id);
        }

        [Fact]
        public async Task GetById_NotFound()
        {
            var result = await _service.GetByIdAsync(1);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetAll()
        {
            var jediMuitos = new List<jedi>{
            new jedi{Id = 1, Name = "VinicinDoMal", Strength = 100, Version = 1 },
            new jedi{Id = 2, Name = "VinicinDoBem", Strength = 110, Version = 1 },
            new jedi{Id = 3, Name = "VinicinDoLOL", Strength = 120, Version = 1 },
            new jedi{Id = 4, Name = "VinicinDoWoW", Strength = 130, Version = 1 }
        };
            _repositoryMock.Setup(r => r.GetAllAsync()).ReturnsAsync(jediMuitos);

            var result = await _service.GetAllAsync();

            Assert.Equal(4, result.Count);
        }
    }
}
