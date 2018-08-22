using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户等级
    /// </summary>
    public class UserRankEntity:BaseEntity
    {
        /// <summary>
        /// 等级积分
        /// </summary>
        public Int32? RandMark { get; set; }

        /// <summary>
        /// 等级名称
        /// </summary>
        public String RandName { get; set; }

    }
}