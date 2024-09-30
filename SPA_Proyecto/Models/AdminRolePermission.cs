using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminRolePermission
{
    public int RoleId { get; set; }

    public int PermissionId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
