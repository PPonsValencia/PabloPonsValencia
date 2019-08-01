using Domain.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Transversal.Logger;

namespace Persistence.Repositories
{
    public class RebelSightingRepositoryFile : IRebelSightingRepository
    {
        private readonly ILogger _log;
        public string FilePath { set; get; }

        public RebelSightingRepositoryFile(ILogger log)
        {
            _log = log;
            FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Persistence\Data\RebelIdentificationFile.txt");
        }

        public bool Add(string rebelName, string planetName)
        {
            var line = rebelName + " on " + planetName + " at " + System.DateTime.Now;

            try
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.WriteLine(line);
                    _log.Debug("Agregada la linea: " + line, this);
                }

                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return false;
            }
        }

        public string ReadLastEntry()
        {
            try
            {
                var lines = File.ReadLines(FilePath).ToList();
                var lastLine = lines.ElementAt(lines.Count() - 1);
                _log.Debug("Recuperada la última linea: " + lastLine, this);

                return lastLine;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return string.Empty;
            }
        }

        public IEnumerable<string> ReadAll()
        {
            try
            {
                var lines = File.ReadLines(FilePath).ToList();
                _log.Debug("Devueltas " + lines.Count() + " rebeldes identificados", this);

                return lines;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return new List<string>();
            }
        }
    }
}
