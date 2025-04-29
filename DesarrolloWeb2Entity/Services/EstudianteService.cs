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
        public string UpdateEstudiante(string identificacion , string nombre, string Apellido,string direccion , string telefono) 
        {
            try 
            {
                var estudiante = db.Estudiante.FirstOrDefault(p => p.Identificacion == identificacion);
                if (estudiante == null) 
                {
                    return "Estusiante No Encontrado";
                }
                estudiante.Identificacion = identificacion;
                estudiante.Nombre = nombre;
                estudiante .Apelllido = Apellido;
                estudiante.Direccion = direccion;
                estudiante.Telefono = telefono;
                db.SaveChanges();
                return "Producto Actualizado correctamente";

            }
            catch(Exception ex)  
            {
                return ex.Message;
            }
        }
        public string DeleteEstudiante(string identificacion)
        {
            try
            {
                var estudiante = db.Estudiante.FirstOrDefault(p => p.Identificacion == identificacion);
                if (estudiante == null)
                {
                    return "Estusiante No Encontrado";
                }
                foreach (var hob in db.Estusiante_Hobbie)
                {
                   if(hob.Identificacion == identificacion) 
                    {
                        db.Estusiante_Hobbie.Remove(hob);
                    }
                }
                db.Estudiante.Remove(estudiante);
                db.SaveChanges();
                return "Estusiante Eliminado";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string CreateEstudiante(string identificacion, string nombre, string Apellido, string direccion, string telefono)
            {
                try
                {
                   var newStuden = new Estudiante
                   {
                       Identificacion = identificacion,
                       Nombre = nombre,
                       Apelllido = Apellido,
                       Direccion = direccion,
                       Telefono = telefono
                   };
                var validacion = db.Estudiante.Any(x => x.Identificacion == identificacion);
                if (validacion) 
                {
                    return "ya existe";
                }

                db.Estudiante.Add(newStuden);
                    db.SaveChanges();
                    return "Producto Actualizado correctamente";

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

        
    }
}