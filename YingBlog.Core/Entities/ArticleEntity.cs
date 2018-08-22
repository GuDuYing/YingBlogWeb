using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 文章信息表
    /// </summary>
    public class ArticleEntity:BaseEntity
    {
        /// <summary>
        /// 文章名称
        /// </summary>
        public String ArticleName { get; set; }

        /// <summary>
        /// 文章发布的时间
        /// </summary>
        public DateTime ArticleTime { get; set; }

        /// <summary>
        /// 文章发布时的Ip
        /// </summary>
        public String ArticleIp { get; set; }

        /// <summary>
        /// 文章浏览次数
        /// </summary>
        public Int32 ArticleClick { get; set; } = 0;

        /// <summary>
        /// 文章组别ID
        /// </summary>
        public long ArticleGroupId { get; set; }

        /// <summary>
        /// 文章所属用户Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 版块id
        /// </summary>
        public Int32? TypeId { get; set; }

        /// <summary>
        /// 文章类型  0为私有，1为公开，2为仅好友查看
        /// </summary>
        public Int32 ArticleType { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        public String ArticleContent { get; set; }

        /// <summary>
        /// 文章是否置顶   0为否，1为是
        /// </summary>
        public Byte ArticleUp { get; set; }

        /// <summary>
        /// 文章是否为博主推荐 0为否，1为是
        /// </summary>
        public Byte ArticleSupport { get; set; }

    }
}