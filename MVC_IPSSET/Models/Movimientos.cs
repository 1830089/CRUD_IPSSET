using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_IPSSET.Models;

public class Movimientos
{
    public int Id { get; set; }
    [Required]
    public float Importe { get; set; }

    [Required]
    public DateTime Fecha_inicio { get; set; }

    [Required]
    public DateTime Fecha_fin { get; set; }
    [Required]
    public Tipo Tipo_id { get; set; }

}
