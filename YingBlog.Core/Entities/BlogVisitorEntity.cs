using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 最近访问表
    /// </summary>
    public class BlogVisitorEntity:BaseEntity
    {
        /// <summary>
        /// 访问者用户id
        /// </summary>
        public long VisitorId { get; set; }

        /// <summary>
        /// 访问时间
        /// </summary>
        public DateTime VisitTime { get; set; }

        /// <summary>
        /// 被访问者用户id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 访问者IP
        /// </summary>
        public String VisitorIp { get; set; }

        /// <summary>
        /// 访问的版块
        /// </summary>
        public Int32? TypeId { get; set; }

        /// <summary>
        /// 访问该版块下的某个项目的ID
        /// </summary>
        public Int32? WhereId { get; set; }

    }
}