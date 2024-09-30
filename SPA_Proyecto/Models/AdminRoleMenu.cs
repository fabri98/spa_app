using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminRoleMenu
{
    public int RoleId { get; set; }

    public int MenuId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
