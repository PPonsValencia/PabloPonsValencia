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

namespace WebService_UnitTest
{
    [TestClass]
    public class RebelIdentificationService_Test
    {
        [TestMethod]
        public void RebelSighting_Test()
        {
            ILogger log = DependencyInjector.DependencyInjectorResolve<ILogger>();
            IFilterRebels filterRebels = DependencyInjector.DependencyInjectorResolve<IFilterRebels>();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new  RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);
            IRebelTrack rebelTrack = new RebelTrack(rebelSightingRepositoryFile, filterRebels, log);
            WebService1 ws1 = new WebService1(rebelTrack, log);

            var rebelName = "Luke";
            var planetName = "Tatooine";
            var result = ws1.RebelSighting(rebelName, planetName);

            Assert.AreEqual(result, true);

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
            WebService1 ws1 = new WebService1(rebelTrack, log);

            ws1.RebelSighting("Luke", "Tantooine");
            ws1.RebelSighting("Han Solo", "Corellia");
            var result = ws1.ReadAll().Count();

            Assert.AreEqual(2, result);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }

        [TestMethod]
        public void ReadByName_Test()
        {
            ILogger log = DependencyInjector.DependencyInjectorResolve<ILogger>();
            IFilterRebels filterRebels = DependencyInjector.DependencyInjectorResolve<IFilterRebels>();
            RebelSightingRepositoryFile rebelSightingRepositoryFile = new RebelSightingRepositoryFile(log);
            rebelSightingRepositoryFile.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\testFile.txt"); ;
            if (File.Exists(rebelSightingRepositoryFile.FilePath))
                File.Delete(rebelSightingRepositoryFile.FilePath);
            IRebelTrack rebelTrack = new RebelTrack(rebelSightingRepositoryFile, filterRebels, log);
            WebService1 ws1 = new WebService1(rebelTrack, log);

            ws1.RebelSighting("Luke", "Tantooine");
            ws1.RebelSighting("Han Solo", "Corellia");
            ws1.RebelSighting("Leia", "Endor");
            var result = ws1.ReadByName("Luke").Count();

            Assert.AreEqual(1, result);

            File.Delete(rebelSightingRepositoryFile.FilePath);
        }
    }
}
