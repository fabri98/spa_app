using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class Turno
{
    public ulong Id { get; set; }

    public ulong IdUser { get; set; }

    public ulong IdServicio { get; set; }

    public DateOnly FechaTurno { get; set; }

    public TimeOnly HoraTurno { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Servicio IdServicioNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
