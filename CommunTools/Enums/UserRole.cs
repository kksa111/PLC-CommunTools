using System.ComponentModel;

namespace CommunTools.Enums
{
    /// <summary>
    /// 用户权限级别
    /// </summary>
    public enum UserRole
    {
        [Description("访客")]
        Guest = 0,
        [Description("普通用户")]
        User = 1,
        [Description("管理员")]
        Admin = 2
    }
}
