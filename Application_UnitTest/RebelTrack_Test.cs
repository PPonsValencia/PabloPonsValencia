using System;
using System.IO;
using System.Linq;
using Application.Interfaces;
using Application.Services;
using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Repositories;
using Transversal.Logger;
using WebService;

namespace Application_UnitTest
{
    [TestClass]
    public class RebelTrack_Test
    {
        [TestMethod]
        public void SaveTrack_Test()
        {
            ILogger log = DependencyInjector.DependencyInjectorResolve<ILogger>();
            IFilterRebels filterRebels = DependencyInjector.DependencyInjectorResolve<IFilterRebels>();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);
            IRebelTrack rebelTrack = new RebelTrack(rebelSightingRepositoryFile, filterRebels, log);

            var rebelName = "Luke";
            var planetName = "Tatooine";
            var result = rebelTrack.SaveTrack(rebelName, planetName);

            Assert.AreEqual(true, result);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }

        [TestMethod]
        public void ReadAll_Test()
        {
            ILogger log = DependencyInjector.DependencyInjectorResolve<ILogger>();
            IFilterRebels filterRebels = DependencyInjector.DependencyInjectorResolve<IFilterRebels>();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);
            IRebelTrack rebelTrack = new RebelTrack(rebelSightingRepositoryFile, filterRebels, log);

            rebelTrack.SaveTrack("Luke", "Tatooine");
            rebelTrack.SaveTrack("Han Solo", "Corellia");
            var result = rebelTrack.ReadAll().Count();

            Assert.AreEqual(2, result);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }
    }
}
