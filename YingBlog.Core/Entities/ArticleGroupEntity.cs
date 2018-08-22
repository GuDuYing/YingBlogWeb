using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 文章组别表
    /// </summary>
    public class ArticleGroupEntity:BaseEntity
    {
        /// <summary>
        /// 所属用户id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 文章分组名称
        /// </summary>
        public String ArticleGroupName { get; set; }
    }
}