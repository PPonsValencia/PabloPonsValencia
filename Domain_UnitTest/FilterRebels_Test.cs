using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_UnitTest
{
    [TestClass]
    public class FilterRebels_Test
    {
        [TestMethod]
        public void ByName()
        {
            FilterRebels filterRebels = new FilterRebels();

            List<string> rebelList = new List<string>();
            rebelList.Add(@"Luke on Tatooine at 01 / 08 / 2019 14:43:12");
            rebelList.Add(@"Han Solo on Corellia at 01 / 08 / 2019 14:44:37");
            rebelList.Add(@"Luke on Corellia at 01 / 08 / 2019 16:04:07");
            rebelList.Add(@"Han Solo on Coruscan at 01 / 08 / 2019 16:10:59");
            rebelList.Add(@"Leia on Coruscan at 01 / 08 / 2019 16:11:41");
            rebelList.Add(@"Leia on Alderaan at 01 / 08 / 2019 16:15:35");
            rebelList.Add(@"Pablo on Tierra at 01 / 08 / 2019 16:43:47");

            var filteredList = filterRebels.ByName(rebelList, "Han Solo");

            Assert.AreEqual(2, filteredList.Count());
        }
    }
}
