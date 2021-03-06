﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public override string ToString()
        {
            return Calle.Trim() + ", " + Localidad.Trim() + ", " + Provincia.Trim();
        }

    }
}
