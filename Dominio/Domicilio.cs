﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Codigopostal { get; set; }
        public string Pais { get; set; }
    }
}
