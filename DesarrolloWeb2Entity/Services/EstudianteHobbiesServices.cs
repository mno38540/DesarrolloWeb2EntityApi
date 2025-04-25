using DesarrolloWeb2Entity.Dtos;
using DesarrolloWeb2Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesarrolloWeb2Entity.Services
{
    public class EstudianteHobbiesServices
    {
        AlumnosEntities db = new AlumnosEntities();
        public EstudianteHobbieDto GetAllStudentHobbies(string id)
        {
            EstudianteHobbieDto resultado = (from e in db.Estudiante
                                             join eh in db.Estusiante_Hobbie on e.Identificacion equals eh.Identificacion
                                             join h in db.Hobbie on eh.CodigoHobbie equals h.Codigo
                                             where e.Identificacion == id
                                             select new EstudianteHobbieDto
                                             {
                                                 Identificacion = e.Identificacion,
                                                 Nombre = e.Nombre,
                                                 Apellido = e.Apelllido,
                                                 Direccion = e.Direccion,
                                                 Telefono = e.Telefono,
                                                 Hobbies = (from eh in db.Estusiante_Hobbie 
                                                            join h in db.Hobbie on eh.CodigoHobbie equals h.Codigo
                                                            where e.Identificacion == id
                                                            select new HobbiesDto 
                                                            {
                                                                Codigo = h.Codigo,
                                                                Nombre = h.Nombre,
                                                                Descripcion = h.Descripcion,
                                                            } ).ToList(),
                                             }).FirstOrDefault();
            return resultado;
        }
    }
}