using System;
using System.Collections.Generic;

namespace _19_EntityFramework.Models;

public partial class Repuesto
{
    public long RepuestoId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public string? Comentarios { get; set; }
}
