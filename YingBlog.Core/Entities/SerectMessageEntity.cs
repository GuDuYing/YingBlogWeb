using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户私信表
    /// </summary>
    public class SerectMessageEntity
    {
        /// <summary>
        /// 发送者用户ID
        /// </summary>
        public long SendUserId { get; set; }

        /// <summary>
        /// 接收者用户ID
        /// </summary>
        public long ReceiveUserId { get; set; }

        /// <summary>
        /// 私信主题    
        /// </summary>
        public String MessageTopic { get; set; }

        /// <summary>
        /// 私信内容
        /// </summary>
        public String MessageContent { get; set; }

        public virtual BlogUserEntity SendUser { get; set; }

        public virtual BlogUserEntity ReceiveUser { get; set; }

    }
}