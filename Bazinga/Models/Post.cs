using System;
using System.Collections.Generic;

namespace Bazinga.Models;

public partial class Post
{
    public int Id { get; set; }

    public int Usuario_Id { get; set; }

    public string? Texto { get; set; }

    public string ImagemUrl { get; set; } = null!;

    public DateTime CriadoEm { get; set; }

    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    public virtual ICollection<Curtida> Curtida { get; set; } = new List<Curtida>();

    public virtual Usuario Usuario { get; set; } = null!;
}
