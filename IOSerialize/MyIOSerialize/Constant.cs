using System.Configuration;

namespace MyIOSerialize
{
    /// <summary>
    /// 配置项读取类   NetCore appsetting读取类
    /// </summary>
    public static class Constant
    {
        public static string LogPath = ConfigurationManager.AppSettings["LogPath"];
    }
}