using DesarrolloWeb2Entity.Dtos;
using DesarrolloWeb2Entity.Model;
using DesarrolloWeb2Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DesarrolloWeb2Entity.WebServices
{
    /// <summary>
    /// Descripción breve de EstudianteWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class EstudianteWS : System.Web.Services.WebService
    {
        private AlumnosEntities db = new AlumnosEntities();

        [WebMethod]
        public List<EstudianteDto> GetAllStuden()
        {
            EstudianteService estudianteService = new EstudianteService();
            return estudianteService.GetAllStudents();
        }

        [WebMethod]
        public EstudianteDto StudentById(string code)
        {
            EstudianteService estudianteService = new EstudianteService();
            return estudianteService.GetStudentById(code);
        }
    }
}
