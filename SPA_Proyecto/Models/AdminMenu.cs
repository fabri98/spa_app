using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminMenu
{
    public uint Id { get; set; }

    public int ParentId { get; set; }

    public int Order { get; set; }

    public string Title { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public string? Uri { get; set; }

    public string? Permission { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
