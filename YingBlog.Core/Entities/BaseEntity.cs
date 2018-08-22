using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 抽象基类
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// 实体id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 实体创建时间
        /// </summary>
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 实体软删除标志
        /// </summary>
        public bool IsDeleted { get; set; } = false;

    }
}