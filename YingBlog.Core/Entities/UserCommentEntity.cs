using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 用户评论表
    /// </summary>
    public class UserCommentEntity
    {
        /// <summary>
        /// 收到评论的用户Id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 版块Id
        /// </summary>
        public Int32? TypeId { get; set; }

        /// <summary>
        /// 评论目标Id   版块下的某内容id
        /// </summary>
        public long CommentTargetId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public long CommentContent { get; set; }

        /// <summary>
        /// 评论用户id
        /// </summary>
        public long CommentUserId { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CommentTime { get; set; }

        /// <summary>
        /// 评论者ip
        /// </summary>
        public String CommentIp { get; set; }
    }
}