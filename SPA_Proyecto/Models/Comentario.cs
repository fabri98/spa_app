using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class Comentario
{
    public uint Id { get; set; }

    public string Mensaje { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
