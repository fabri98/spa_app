using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class Noticia
{
    public ulong Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Resumen { get; set; } = null!;

    public string Contenido { get; set; } = null!;

    public string ImagenUrl { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public DateOnly FechaPublicacion { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
