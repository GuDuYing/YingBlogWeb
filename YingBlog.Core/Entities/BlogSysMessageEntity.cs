using System;

namespace YingBlog.Core.Entities
{
    public class BlogSysMessageEntity:BaseEntity
    {
        public long? SendUserId { get; set; }

        public long? SendGroupId { get; set; }

        /// <summary>
        /// 默认发送   0为所有用户  1特定用户
        /// </summary>
        public Byte Send_Default { get; set; }

        public String SysMessageTopic { get; set; }

        public String SysMessageContent { get; set; }

    }
}