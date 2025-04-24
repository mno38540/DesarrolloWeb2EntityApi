using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesarrolloWeb2Entity.Dtos;
using DesarrolloWeb2Entity.Model;

namespace DesarrolloWeb2Entity.Services
{
    public class HobbieServices
    {
        private AlumnosEntities db = new AlumnosEntities();
        public HobbieServices() { }

        public List<HobbiesDto> GetAllHobbies() 
        {
            List<HobbiesDto> resultado =  (from h in db.Hobbie 
                                              select new HobbiesDto 
                                              {
                                                  Codigo = h.Codigo,
                                                  Nombre = h.Nombre,
                                                  Descripcion = h.Descripcion,
                                              }).ToList();
            return resultado;
        }

        public HobbiesDto GetHobbiesById(string code)
        {
            var resultado = (from h in db.Hobbie
                             where h.Codigo == code
                             select new HobbiesDto 
                             {
                                 Codigo = h.Codigo,
                                 Nombre = h.Nombre,
                                 Descripcion = h.Descripcion
                             }).ToList();
            return resultado.FirstOrDefault();
        }
    }
}