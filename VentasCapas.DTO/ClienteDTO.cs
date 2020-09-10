﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasCapas.DTO
{
    [Serializable]
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    
    }
}
