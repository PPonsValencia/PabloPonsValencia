using Application.Interfaces;
using Domain.Interfaces;
using Domain.Services;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using Transversal.Logger;

namespace Application.Services
{
    public class RebelTrack : IRebelTrack
    {
        private readonly IRebelSightingRepository _rebelSightingRepository;
        private readonly IFilterRebels _filterRebels;
        private readonly ILogger _log;
        
        public RebelTrack(IRebelSightingRepository rebelSightingRepository, IFilterRebels filterRebels, ILogger log)
        {
            _rebelSightingRepository = rebelSightingRepository;
            _filterRebels = filterRebels;
            _log = log;
        }

        public bool SaveTrack(string rebelName, string planetName)
        {
            try
            {
                var result = _rebelSightingRepository.Add(rebelName, planetName);
                _log.Debug("Agregado rebelde " + rebelName + " en " + planetName, this);

                return result;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return false;
            }
        }

        public IEnumerable<string> ReadAll()
        {
            try
            {
                var result = _rebelSightingRepository.ReadAll();
                _log.Debug("Se han recuperado " + result.Count() + " lineas", this);

                return result;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return new List<string>();
            }
        }

        public IEnumerable<string> ReadByName(string rebelName)
        {
            try
            {
                var rebelList = _rebelSightingRepository.ReadAll();
                var rebelByNameList = _filterRebels.ByName(rebelList, rebelName);
                _log.Debug("Se han obtenido " + rebelByNameList.Count() + " de " + rebelList.Count() + "resultados", this);

                return rebelByNameList;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return new List<string>();
            }
        }
    }
}
