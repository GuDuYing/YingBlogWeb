using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户留言表
    /// </summary>
    public class BlogStayMessageEntity:BaseEntity
    {
        /// <summary>
        /// 被留言用户ID
        /// </summary>
        public long BlogUserId { get; set; }

        /// <summary>
        /// 留言用户id
        /// </summary>
        public long StayUserId { get; set; }

        /// <summary>
        /// 留言的内容
        /// </summary>
        public String MessageContent { get; set; }

        /// <summary>
        /// 留言用户的IP
        /// </summary>
        public String StayUserIp { get; set; }

        /// <summary>
        /// 留言时的时间
        /// </summary>
        public DateTime? MessageStayTime { get; set; }



    }
}