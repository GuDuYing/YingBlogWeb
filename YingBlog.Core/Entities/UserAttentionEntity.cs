namespace YingBlog.Core.Entities
{
    public class UserAttentionEntity:BaseEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public long BlogUserId { get; set; }

        /// <summary>
        /// 关注ID
        /// </summary>
        public long AttentionId { get; set; }

        public virtual BlogUserEntity BlogUser { get; set; }

        public virtual BlogUserEntity AttentionUser { get; set; }

    }
}