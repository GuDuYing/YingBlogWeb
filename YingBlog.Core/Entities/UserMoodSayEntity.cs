using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户心情说说表
    /// </summary>
    public class UserMoodSayEntity:BaseEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 发布说说时间
        /// </summary>
        public DateTime SayTime { get; set; }

        /// <summary>
        /// 发布说说时IP
        /// </summary>
        public String SayIp { get; set; }

        /// <summary>
        /// 说说内容
        /// </summary>
        public String SayContent { get; set; }

        /// <summary>
        /// 版块id
        /// </summary>
        public Int32? TypeId { get; set; }

    }
}