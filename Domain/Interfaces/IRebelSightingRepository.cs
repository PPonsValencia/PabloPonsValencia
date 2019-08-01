using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRebelSightingRepository
    {
        bool Add(string rebelName, string planetName);
        string ReadLastEntry();
        IEnumerable<string> ReadAll();
    }
}
