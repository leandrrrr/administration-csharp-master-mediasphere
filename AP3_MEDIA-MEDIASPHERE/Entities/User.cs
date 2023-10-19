using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class User
{
    public int IdUser { get; set; }

    public string NomUser { get; set; } = null!;

    public string PrenomUser { get; set; } = null!;

    public string? MailUser { get; set; }

    public string? MdpUser { get; set; }
}
