using System.Collections.Generic;
using CommunTools.Enums;

namespace CommunTools.Common
{
    /// <summary>
    /// 管理登录用户信息
    /// </summary>
    public static class UserSession
    {
        private static readonly Dictionary<string, (string Password, UserRole Role)> _users =
            new Dictionary<string, (string, UserRole)>()
            {
                { "admin", ("admin", UserRole.Admin) },
                { "user", ("user", UserRole.User) }
            };

        public static string UserName { get; private set; } = string.Empty;
        public static UserRole Role { get; private set; } = UserRole.Guest;

        public static bool Login(string name, string password)
        {
            if (_users.TryGetValue(name, out var info) && info.Password == password)
            {
                UserName = name;
                Role = info.Role;
                return true;
            }
            return false;
        }
    }
}
