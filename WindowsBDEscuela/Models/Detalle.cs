﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        public int DetalleId { get; set; }
        public int PlanillaId { get; set; }
        public int EstadoId { get; set; }

        #region Propiedades de navegacion
        [ForeignKey("EstadoId")]
        public Estado Estado { get; set; }
        [ForeignKey("PlanillaId")]
        public Planilla Planilla { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }

        #endregion

    }
}
