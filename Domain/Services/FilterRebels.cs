using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
    public class FilterRebels : IFilterRebels
    {
        public IEnumerable<string> ByName(IEnumerable<string> rebelList, string rebelName)
        {
            return rebelList.Where(x => x.Substring(0, x.IndexOf(" on ")).Contains(rebelName));
        }
    }
}
