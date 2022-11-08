﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        #region Propiedades de navegacion

        public List<Planilla> Planillas { get; set; }
        [ForeignKey("LocalidadId")]
        public Localidad Localidad { get; set; }

        #endregion
    }
}
