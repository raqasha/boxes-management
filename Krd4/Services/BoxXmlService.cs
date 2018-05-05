using Krd4.Helpers;
using Krd4.Helpers.Interfaces;
using Krd4.Models;
using Krd4.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace Krd4.Services
{
    //szkuras@gmail.com
    public class BoxXmlService : IBoxService
    {
        private const string FILENAME = "Boxes.xml";
        IList<Box> _boxes;
        IFileHelper<Box> _boxHelper;

        public BoxXmlService()
        {
            _boxes = new List<Box>();
            _boxHelper = new BoxFileHelper();
        }

        public void Add(Box model)
        {
            ReadFromFile();
            model.Id = _boxes.Count + 1;

            _boxes.Add(model);
            _boxHelper.SaveToFile(_boxes, FILENAME);
        }

        public void Delete(int id)
        {
            ReadFromFile();
            var box = _boxes.Where(b => b.Id == id).FirstOrDefault();
            _boxes.Remove(box);
            _boxHelper.SaveToFile(_boxes, FILENAME);
        }

        public IEnumerable<Box> GetAll()
        {
            ReadFromFile();
            return _boxes.AsEnumerable();
        }

        public Box GetById(int id)
        {
            ReadFromFile();
            var box = _boxes.Where(b => b.Id == id).FirstOrDefault();
            return box;
        }

        public IEnumerable<Box> GetByUserId(User user)
        {
            ReadFromFile();
            var boxes = _boxes.Where(b => b.UserId == user.Id).ToList();
            return boxes;
        }

        private void ReadFromFile()
        {
            if (_boxes != null)
            {
                _boxes = _boxHelper.ReadFromFile(FILENAME);
            }
            else
            {
                _boxes = new List<Box>();
                _boxes = _boxHelper.ReadFromFile(FILENAME);
            }
        }
    }
}
