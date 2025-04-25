using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesarrolloWeb2Entity.Dtos;

namespace DesarrolloWeb2Entity.Dtos
{
    public class EstudianteHobbieDto
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<HobbiesDto> Hobbies { get; set; }

    }
}