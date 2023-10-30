using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Auteur
{
    public int IdAuteur { get; set; }

    public string NomAuteur { get; set; } = null!;

    public string PrenomAuteur { get; set; } = null!;

    public virtual ICollection<AuteurRessource> AuteurRessources { get; set; } = new List<AuteurRessource>();
}
