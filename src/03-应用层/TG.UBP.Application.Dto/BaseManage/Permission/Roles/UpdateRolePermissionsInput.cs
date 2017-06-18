﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TG.UBP.Application.Dto.BaseManage.Permission.Roles
{
    public class UpdateRolePermissionsInput
    {
        [Range(1, int.MaxValue)]
        public int RoleId { get; set; }

        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}