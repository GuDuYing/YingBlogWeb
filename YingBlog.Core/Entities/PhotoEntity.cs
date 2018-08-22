using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 相片表
    /// </summary>
    public class PhotoEntity:BaseEntity
    {
        /// <summary>
        /// 相片名称
        /// </summary>
        public String PhotoName { get; set; }

        /// <summary>
        /// 相片存放地址
        /// </summary>
        public String PhotoUrl { get; set; }

        /// <summary>
        /// 相片描述
        /// </summary>
        public String PhotoDescription { get; set; }

        /// <summary>
        /// 所属用户Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 所属相片组别id
        /// </summary>
        public long PhotoGroupId { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime UploadTime { get; set; }

        /// <summary>
        /// 上传ip
        /// </summary>
        public String UploadIp { get; set; }

    }
}