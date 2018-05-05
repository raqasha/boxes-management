using Krd4.Helpers.Interfaces;
using Krd4.Models;
using Krd4.Services;
using Krd4.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


namespace Krd4.Test.Services
{
    [TestFixture]
    public class UserXmlServiceTests
    {
        private IUserService _sut;

        private Mock<IFileHelper<User>> _fileHelperMock;

        [SetUp]
        public void SetUp()
        {
            _fileHelperMock = new Mock<IFileHelper<User>>();
            _sut = new UserXmlService(_fileHelperMock.Object);
        }

        [Test]
        public void Add_Should_AddUser()
        {
            //User user = new User();
            //It.IsAny<string>()
            //_fileHelperMock.Setup(x => x.ReadFromFile("Users.xml")).Returns(new List<User>());
            //_sut.Add(user);
            //_fileHelperMock.Verify(x => x.SaveToFile(It.IsAny<List<User>>(), "Users.xml"), Times.Once);

            IList<User> users = new List<User>()
            {
                new User() { Id = 1 },
                new User() { Id = 2 }
            };
            _fileHelperMock.Setup(u => u.ReadFromFile("Users.xml")).Returns(users);
            var userToAdd = new User();

            _sut.Add(userToAdd);
            Assert.IsTrue(users.Contains(userToAdd));
            _fileHelperMock.Verify(x => x.SaveToFile(users, "Users.xml"), Times.Once);


        }

        [Test]
        [TestCase(1)]
        public void Delete_Should_DeleteUserById(int id)
        {
            IList<User> users = new List<User>()
            {
                new User() { Id = 1 },
                new User() { Id = 2 }
            };
            _fileHelperMock.Setup(u => u.ReadFromFile("Users.xml")).Returns(users);
            var userToDelete = users.Where(u => u.Id == id).FirstOrDefault();

            _sut.Delete(id);
            Assert.IsFalse(users.Contains(userToDelete));
            _fileHelperMock.Verify(x => x.SaveToFile(users, "Users.xml"), Times.Once);

        }

        [Test]
        public void GetAll_Should_ReturnAllFromList()
        {
            IList<User> users = new List<User>()
            {
                new User() { Id = 1 },
                new User() { Id = 2 }
            };
            _fileHelperMock.Setup(u => u.ReadFromFile("Users.xml")).Returns(users);

            var result = _sut.GetAll();
            Assert.IsNotEmpty(result);
        }

        [Test]
        [TestCase(1)]
        public void GetById_Should_ReturnOneUser(int id)
        {
            IList<User> users = new List<User>()
            {
                new User() { Id = 1 },
                new User() { Id = 2 }
            };
            _fileHelperMock.Setup(u => u.ReadFromFile("Users.xml")).Returns(users);
            var user = users.Where(u => u.Id == id).FirstOrDefault();
            var result = _sut.GetById(id);
            Assert.AreEqual(user, result);
        }


    }
}
