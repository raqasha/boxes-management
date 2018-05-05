using Krd4.Models;
using System.Collections.Generic;

namespace Krd4.Services.Interfaces
{
    public interface IBoxService : IService<Box>
    {
        IEnumerable<Box> GetByUserId(User user);
    }
}
