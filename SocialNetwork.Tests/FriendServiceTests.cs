using Moq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class FriendServiceTests
    {
        private Mock<IFriendRepository> _friendRepositoryMock;
        private FriendService _friendService;

        [SetUp]
        public void Setup()
        {
            _friendRepositoryMock = new Mock<IFriendRepository>();
            _friendService = new FriendService(_friendRepositoryMock.Object);
        }

        [Test]
        public void AddFriend_ValidUsers_CreatesNewFriendship()
        {
           
            int userId = 1;
            int friendId = 2;

            _friendRepositoryMock.Setup(r => r.Create(It.IsAny<FriendEntity>())).Returns(1);

            
            _friendService.AddFriend(userId, friendId);

           
            _friendRepositoryMock.Verify(r => r.Create(It.IsAny<FriendEntity>()));
        }

    }
}
