using System;
using System.Collections.Generic;

namespace SPA_Proyecto.Models;

public partial class AdminUserPermission
{
    public int UserId { get; set; }

    public int PermissionId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
