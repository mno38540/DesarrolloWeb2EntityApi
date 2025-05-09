﻿using DesarrolloWeb2Entity.Dtos;
using DesarrolloWeb2Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DesarrolloWeb2Entity.WebServices
{
    /// <summary>
    /// Descripción breve de HobbieWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class HobbieWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<HobbiesDto> HobbiesGetAll()
        {
            HobbieServices hobbieServices = new HobbieServices();
            return hobbieServices.GetAllHobbies();
        }

        [WebMethod]
        public HobbiesDto HobbiesGetByIdl(string code)
        {
            HobbieServices hobbieServices = new HobbieServices();
            return hobbieServices.GetHobbiesById(code);
        }
    }
}
