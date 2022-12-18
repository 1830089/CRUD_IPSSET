using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_IPSSET.Models;

public class Movimientos
{
    public int Id { get; set; }
    public float Importe { get; set; }

    public int tipoid { get; set; }
    public DateTime Fecha_inicio { get; set; }

    public DateTime Fecha_fin { get; set; }

    [ForeignKey("tipoid")]
    public Tipo Tipo { get; set; }


}
