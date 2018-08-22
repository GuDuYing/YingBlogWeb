using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 博客用户组
    /// </summary>
    public class BlogGroupEntity:BaseEntity
    {
        /// <summary>
        /// 组别名称
        /// </summary>
        public String GroupName { get; set; }

        
    }
}