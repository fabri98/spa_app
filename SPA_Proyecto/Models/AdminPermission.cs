﻿using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminPermission
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? HttpMethod { get; set; }

    public string? HttpPath { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
