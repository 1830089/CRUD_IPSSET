using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace MVC_IPSSET.Models;

public class Tipo_sexo
{
    public int Id { get; set; }

    [Required]
    public string tipo { get; set; }
}
