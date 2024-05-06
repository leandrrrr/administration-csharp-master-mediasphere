using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Commentaire
{
    public int IdCommentaire { get; set; }

    public int IdRessource { get; set; }

    public int IdUtilisateur { get; set; }

    public string Contenu { get; set; } = null!;

    public int Note { get; set; }

    public DateTime DateCreation { get; set; }

    public virtual Ressource IdRessourceNavigation { get; set; } = null!;

    public virtual Emprunteur IdUtilisateurNavigation { get; set; } = null!;
}
