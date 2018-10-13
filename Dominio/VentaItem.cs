﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentaItem
    {
        public int IdVentaItem { get; set; }
        public RegistroVenta Venta { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioParcial { get; set; }

        public override string ToString()
        {
            return IdVentaItem.ToString();
        }
    }
}
