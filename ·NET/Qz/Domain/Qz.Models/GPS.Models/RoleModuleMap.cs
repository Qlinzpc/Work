using System;
using System.Collections.Generic;

namespace Qz.GPS.Models
{
    public partial class RoleModuleMap
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public virtual Role Role { get; set; }
    }
}
