using System;
using System.Collections.Generic;

namespace Bazinga.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SenhaHash { get; set; } = null!;

    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    public virtual ICollection<Curtida> Curtida { get; set; } = new List<Curtida>();

    public virtual ICollection<Post> Post { get; set; } = new List<Post>();
}
