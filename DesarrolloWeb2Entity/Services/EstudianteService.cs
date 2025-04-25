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
                                              Apellido = e.Apelllido,
                                              Direccion = e.Direccion,
                                              Telefono = e.Telefono,
                                          }).ToList();
            return resultado;
        }

        public EstudianteDto GetStudentById(string code)
        {
            EstudianteDto resultado = (from e in db.Estudiante
                             where e.Identificacion == code
                             select new EstudianteDto
                             {
                                 Identificacion = e.Identificacion,
                                 Nombre = e.Nombre,
                                 Apellido = e.Apelllido,
                                 Direccion = e.Direccion,
                                 Telefono = e.Telefono,
                             }).FirstOrDefault();
            return resultado;
        }
    }
}