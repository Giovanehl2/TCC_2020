﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAnalyser.Controllers
{
    public class TelaInicialController : Controller
    {
        // GET: TelaIniciala
        public ActionResult TelaInicial()
        {
            try
            {
                //AdmUsuario AdmUsuario = new AdmUsuario();


                return View();
            }
            catch (Exception ex)
            {
                return View();
            }

        }
    }
}