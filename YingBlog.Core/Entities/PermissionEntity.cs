using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 权限实体表
    /// </summary>
    public class PermissionEntity:BaseEntity
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public String PermissionName { get; set; }
        
    }
}