using System;
using System.Collections.Generic;


namespace MVC_IPSSET.Models;

public class Personas
{
    public int Id { get; set; }

    public int n_pension { get; set; }

    public bool cobro_indebido { get; set; }

    public string Nombre { get; set; }
    public string Apellido_paterno { get; set; }
    public string Apellido_materno { get; set; }
    public DateTime Fecha_nacimiento { get; set; }

    public string RFC { get; set; }

    public string Curp { get; set; }

    //foreign key
    public int Sexo { get; set; }

    public int Pension { get; set; }

    public int Estado_civil { get; set; }



}
