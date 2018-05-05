using Krd4.Models;
using System.Collections.Generic;

namespace Krd4.Helpers.Interfaces
{
    public interface IFileHelper<T> where T: BaseModel
    {
        void SaveToFile(IList<T> data, string filename);
        IList<T> ReadFromFile(string filename);
    }
}
