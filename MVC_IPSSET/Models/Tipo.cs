﻿using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;

namespace MVC_IPSSET.Models;

public class Tipo
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }
}
