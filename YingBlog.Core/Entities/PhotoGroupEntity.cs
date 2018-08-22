using System;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 相片组别表
    /// </summary>
    public class PhotoGroupEntity:BaseEntity
    {
        /// <summary>
        /// 相片组别名称
        /// </summary>
        public String ImgGroupName { get; set; }

        /// <summary>
        /// 相片组别类型  0->仅主人可见,1->输入密码即可查看,2->仅好友能查看,3->回答问题即可查看
        /// </summary>
        public String ImgGroupType { get; set; }

        /// <summary>
        /// 组别查看密码
        /// </summary>
        public String ImgPassword { get; set; }

        /// <summary>
        /// 该组别所属用户id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 组别访问问题
        /// </summary>
        public String ImgQuestion { get; set; }

        /// <summary>
        /// 该问题的答案
        /// </summary>
        public String ImgAnswer { get; set; }

        /// <summary>
        /// 版块Id   默认为1
        /// </summary>
        public Int32 TypeId { get; set; } = 1;

        /// <summary>
        /// 组别封面图片地址
        /// </summary>
        public String ImgTopSrc { get; set; }

    }
}