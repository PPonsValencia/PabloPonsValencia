using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Repositories;
using System;
using System.IO;
using System.Linq;
using Transversal.Logger;

namespace Persistence_UnitTest
{
    [TestClass]
    public class RebelSightingRepositoryFile_Test
    {
        [TestMethod]
        public void Add_Test()
        {
            ILogger log = new LoggerLog4Net();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);

            var rebelName = "Luke";
            var planetName = "Tatooine";
            var success = rebelSightingRepositoryFile.Add(rebelName, planetName);

            Assert.AreEqual(true, success);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }

        [TestMethod]
        public void ReadLastLine_Test()
        {
            ILogger log = new LoggerLog4Net();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);

            var rebelName = "Luke";
            var planetName = "Tatooine";
            rebelSightingRepositoryFile.Add(rebelName, planetName);
            var lastLine = rebelSightingRepositoryFile.ReadLastEntry();
            var contains = lastLine.Contains(rebelName + " on " + planetName +  " at ");

            Assert.AreEqual(true, contains);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }

        [TestMethod]
        public void ReadAll_Test()
        {
            ILogger log = new LoggerLog4Net();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
               File.Delete(rebelSightingRepositoryFile.FilePath);

            rebelSightingRepositoryFile.Add("Luke", "Tatooine");
            rebelSightingRepositoryFile.Add("Han Solo", "Corellia");
            var nFilas = rebelSightingRepositoryFile.ReadAll().Count();

            Assert.AreEqual(2, nFilas);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }
    }
}
