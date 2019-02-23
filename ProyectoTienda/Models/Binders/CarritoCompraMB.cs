﻿using ProyectoTienda.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTienda.Models.Binders
{
    public class CarritoCompraMB: IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            CarritoCompra p = (CarritoCompra)controllerContext.HttpContext.Session["KEY"];
            if (p == null)
            {
                p = new CarritoCompra();
                controllerContext.HttpContext.Session["KEY"] = p;
            }
            return p;
        }
    }
}