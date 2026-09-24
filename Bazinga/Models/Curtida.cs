using System;
using System.Collections.Generic;

namespace Bazinga.Models;

public partial class Curtida
{
    public int Usuario_Id { get; set; }

    public int Post_Id { get; set; }

    public DateTime CriadoEm { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
