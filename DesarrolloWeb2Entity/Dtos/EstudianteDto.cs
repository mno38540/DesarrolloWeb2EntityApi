﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesarrolloWeb2Entity.Dtos
{
    public class EstudianteDto
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono{ get; set; }

    }
}