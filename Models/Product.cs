﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public CategoryProduct IdCategoria { get; set;}
    }
}