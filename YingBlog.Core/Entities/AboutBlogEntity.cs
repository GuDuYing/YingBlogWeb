using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 博客信息表
    /// </summary>
    public class AboutBlogEntity:BaseEntity
    {
        /// <summary>
        /// 博客关键字
        /// </summary>
        public String BlogKeyWord { get; set; }

        /// <summary>
        /// 博客描述
        /// </summary>
        public String BlogDescription { get; set; }

        /// <summary>
        /// 博客名称
        /// </summary>
        public String BlogName { get; set; }

        /// <summary>
        /// 博客标题
        /// </summary>
        public String BlogTitle { get; set; }


    }
}