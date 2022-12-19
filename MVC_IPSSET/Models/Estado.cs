using MessagePack;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace MVC_IPSSET.Models;

public class Estado
{

    public int Id { get; set; }
    [Required]
    public string NombreEstado { get; set; }
}
