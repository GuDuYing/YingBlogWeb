namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户好友实体表
    /// </summary>
    public class BlogFriendEntity:BaseEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long BlogUserId { get; set; }

        /// <summary>
        /// 好友ID
        /// </summary>
        public long FriendId { get; set; }

        public virtual BlogUserEntity BlogUser { get; set; }

        public virtual BlogUserEntity FriendUser { get; set; }
    }
}