using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class Servicio
{
    public ulong Id { get; set; }

    public string NombreServicio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
