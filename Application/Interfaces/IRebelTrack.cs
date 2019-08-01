using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IRebelTrack
    {
        bool SaveTrack(string rebelName, string planetName);
        IEnumerable<string> ReadAll();
        IEnumerable<string> ReadByName(string rebelName);
    }
}
