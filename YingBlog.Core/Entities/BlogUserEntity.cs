using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace YingBlog.Core.Entities
{
    /// <summary>
    /// 博客用户实体表
    /// </summary>
    public class BlogUserEntity:BaseEntity
    {
        /// <summary>
        /// 博客用户名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public String RealName { get; set; }

        /// <summary>
        /// 用户加密密码
        /// </summary>
        public String PasswordHash { get; set; }

        /// <summary>
        /// 用户密码盐
        /// </summary>
        public String PasswordSalt { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [MaxLength(11)]
        public String PhoneNumber { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        public Byte? UserSex { get; set; }

        /// <summary>
        /// 用户QQ号码
        /// </summary>
        public String QQNumber { get; set; }

        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [EmailAddress]
        public String UserEmail { get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        public String UserAddress { get; set; }

        /// <summary>
        /// 用户积分
        /// </summary>
        public Int32? UserMark { get; set; }

        /// <summary>
        /// 用户等级
        /// </summary>
        public Int64? RankId { get; set; }

        /// <summary>
        /// 用户上一次登陆时间
        /// </summary>
        public DateTime? UserLastLoginTime { get; set; }

        /// <summary>
        /// 用户上一次登陆IP
        /// </summary>
        public String UserLastLoginIp { get; set; }

        /// <summary>
        /// 用户生日
        /// </summary>
        public String UserBirthday { get; set; }

        /// <summary>
        /// 用户自我描述
        /// </summary>
        public String UserDescription { get; set; }

        /// <summary>
        /// 用户头像存储路径
        /// </summary>
        public String UserImageUrl { get; set; }

        /// <summary>
        /// 用户毕业学校
        /// </summary>
        public String UserSchool { get; set; }

        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime UserRegisterTime { get; set; }

        /// <summary>
        /// 用户注册IP
        /// </summary>
        public String UserRegisterIp { get; set; }

        /// <summary>
        /// 用户微博
        /// </summary>
        public String UserWeiBo { get; set; }

        /// <summary>
        /// 用户血型
        /// </summary>
        public String UserBloodType { get; set; }

        /// <summary>
        /// 用户语录
        /// </summary>
        public String UserSays { get; set; }

        /// <summary>
        /// 用户锁定状态
        /// </summary>
        public Byte? UserIsLock { get; set; }

        /// <summary>
        /// 用户冻结状态
        /// </summary>
        public Byte? UserIsFreeze { get; set; }

        


    }
}