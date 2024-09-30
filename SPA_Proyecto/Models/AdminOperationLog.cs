using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminOperationLog
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public string Path { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string Input { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
