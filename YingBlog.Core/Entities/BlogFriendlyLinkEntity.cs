using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 博客友情链接表
    /// </summary>
    public class BlogFriendlyLinkEntity:BaseEntity
    {
        /// <summary>
        /// 外链名称
        /// </summary>
        public String LinkName { get; set; }

        /// <summary>
        /// 外链Url
        /// </summary>
        public String LinkUrl { get; set; }

        /// <summary>
        /// 外链LogoUrl
        /// </summary>
        public String LinkLogoUrl { get; set; }

        /// <summary>
        /// 在页面显示的顺序
        /// </summary>
        public String ShowOrder { get; set; }

    }
}