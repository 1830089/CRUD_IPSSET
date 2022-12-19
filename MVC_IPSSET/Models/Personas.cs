using MessagePack;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_IPSSET.Models;

public class Personas
{
    public int Id { get; set; }

    [Required]
    public int n_pension { get; set; }

    [Required]
    public bool cobro_indebido { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido_paterno { get; set; }

    [Required]
    public string Apellido_materno { get; set; }
    [Required]
    public DateTime Fecha_nacimiento { get; set; }

    [Required]
    public string RFC { get; set; }

    [Required]

    public string Curp { get; set; }

    //foreign key

    [Required]
    public Tipo_sexo id_Sexo { get; set; }

    [Required]
    public Pension id_Pension { get; set; }

    [Required]
    public Estado Estado_civil { get; set; }


    [Required]
    public List<Movimientos> Movimientos { get; set; }



}
