using Krd4.Helpers;
using Krd4.Helpers.Interfaces;
using Krd4.Models;
using Krd4.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Krd4.Services
{
    public class UserXmlService : IUserService
    {
        private const string FILENAME = "Users.xml";
        IList<User> _users;
        IFileHelper<User> _fileHelper;

        public UserXmlService(IFileHelper<User> fileHelper)
        {
            _fileHelper = fileHelper;
            //_users = new List<User>();
            //lub przed i po wywołaniu metody w osobnych funkcjach, wyjebać konstruktor
            //działać na liście _users
        }

        public UserXmlService() : this(new UserFileHelper())
        {

        }

        //XmlSerializer 
        public void Add(User model)
        {
            ReadFromFile();

            int id = _users.Count() + 1;
            model.Id = id;

            _users.Add(model);
            _fileHelper.SaveToFile(_users, FILENAME);
        }

        public void Delete(int id)
        {
            ReadFromFile();
            var user = _users.Where(u => u.Id == id).FirstOrDefault();
            _users.Remove(user);
            _fileHelper.SaveToFile(_users, FILENAME);
        }

        public IEnumerable<User> GetAll()
        {
            ReadFromFile();
            return _users.AsEnumerable();
        }

        public User GetById(int id)
        {
            ReadFromFile();
            return _users.Where(u => u.Id == id).FirstOrDefault();
        }

        public User Login(string login, string password)
        {
            ReadFromFile();
            var user = _users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
            return user;
        }

        private void ReadFromFile()
        {
            if (_users != null)
            {
                _users = _fileHelper.ReadFromFile(FILENAME);
            }
            else
            {
                _users = new List<User>();
                _users = _fileHelper.ReadFromFile(FILENAME);
            }
        }
    }
}
