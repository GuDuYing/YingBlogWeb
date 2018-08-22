using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 短信记录表
    /// </summary>
    public class PhoneMessageEntity:BaseEntity
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        public String PhoneNum { get; set; }

        /// <summary>
        /// 发送内容
        /// </summary>
        public String Content { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 所属用户id
        /// </summary>
        public long UserId { get; set; }


    }
}