using DesarrolloWeb2Entity.Dtos;
using DesarrolloWeb2Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesarrolloWeb2Entity.Services
{
    public class EstudianteService
    {
        AlumnosEntities db = new AlumnosEntities();
        public List<EstudianteDto> GetAllStudents()
        {
            List<EstudianteDto> resultado = (from e in db.Estudiante
                                          select new EstudianteDto
                                          {
                                              Identificacion = e.Identificacion,
                                              Nombre = e.Nombre,
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