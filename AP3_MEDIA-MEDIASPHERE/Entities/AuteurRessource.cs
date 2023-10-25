using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class AuteurRessource
{
    public int IdRessource { get; set; }

    public int IdAuteur { get; set; }
    public virtual Auteur IdAuteurNavigation { get; set; } = null!;

}
