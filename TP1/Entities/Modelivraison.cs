using System;
using System.Collections.Generic;

namespace TP1.Entities;

public partial class Modelivraison
{
    public int Idmode { get; set; }

    public string? Mode { get; set; }

    public virtual ICollection<Livraison> Livraisons { get; set; } = new List<Livraison>();
}
