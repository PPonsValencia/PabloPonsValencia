using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Transversal.Logger;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private readonly IRebelTrack _rebelTrack;
        private readonly ILogger _log;

        public WebService1()
        {
            _rebelTrack = DependencyInjector.DependencyInjectorResolve<IRebelTrack>();
            _log = DependencyInjector.DependencyInjectorResolve<ILogger>();
        }

        public WebService1(IRebelTrack rebelTrack, ILogger log)
        {
            _rebelTrack = rebelTrack;
            _log = log;
        }

        [WebMethod]
        public bool RebelSighting(string rebelName, string planetName)
        {
            try
            {
                var result = _rebelTrack.SaveTrack(rebelName, planetName);
                _log.Debug("Rebelde agregado con éxito", this);

                return result;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message, this);
                return false;
            }
        }

        [WebMethod]
        public List<string> ReadAll()
        {
            try
            {
                var result = _rebelTrack.ReadAll().ToList();
                _log.Debug("Leidas todas las identificaciones con éxito", this);

                return result;
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message, this);
                return new List<string>();
            }
        }

        [WebMethod]
        public List<string> ReadByName(string rebelName)
        {
            try
            {
                var result = _rebelTrack.ReadByName(rebelName).ToList();
                _log.Debug("Filtrados los rebeldes con éxito", this);

                return result;
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message, this);
                return new List<string>();
            }
        }
    }
}
