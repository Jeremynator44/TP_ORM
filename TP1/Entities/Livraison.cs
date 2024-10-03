using System;
using System.Collections.Generic;

namespace TP1.Entities;

public partial class Livraison
{
    public int Idlivraison { get; set; }

    public string Nom { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Idmode { get; set; }

    public virtual Modelivraison IdmodeNavigation { get; set; } = null!;
}
