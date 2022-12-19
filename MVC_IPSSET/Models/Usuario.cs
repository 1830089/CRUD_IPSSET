using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace MVC_IPSSET.Models;

public partial class Usuario
{
    public int Id { get; set; }

    [Required]
    public string? Nombre { get; set; }

    [Required]

    public DateTime? Fecha { get; set; }
    
    [Required]

    public string? Clave { get; set; }
}
