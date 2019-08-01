using System.Collections.Generic;

namespace Domain.Services
{
    public interface IFilterRebels
    {
        IEnumerable<string> ByName(IEnumerable<string> rebelList, string rebelName);
    }
}