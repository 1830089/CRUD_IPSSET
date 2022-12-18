using System;
using System.Collections.Generic;

namespace MVC_IPSSET.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre_usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Clave { get; set; }
}
