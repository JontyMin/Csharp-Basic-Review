using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace MyIOSerialize.IO
{
    public class Recursion
    {
        /// <summary>
        /// 获取文件夹下所有文件
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public static List<DirectoryInfo> GetAllDirectory(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                return new List<DirectoryInfo>();
            }

            List<DirectoryInfo> directoryInfos = new List<DirectoryInfo>();

            DirectoryInfo directory = new DirectoryInfo(rootPath);
            directoryInfos.Add(directory);

            GetChildDirectory(directoryInfos, directory);

            return directoryInfos;
        }

        /// <summary>
        /// 递归获取子文件夹
        /// 自动迭代 耗费资源
        /// </summary>
        /// <param name="directoryInfos"></param>
        /// <param name="directoryParent"></param>
        private static void GetChildDirectory(List<DirectoryInfo> directoryInfos, DirectoryInfo directoryParent)
        {
            DirectoryInfo[] directoryChildInfos = directoryParent.GetDirectories();//一级文件夹
            if (directoryChildInfos.Length > 0)// 递归的跳出条件
            {
                directoryInfos.AddRange(directoryChildInfos);
                foreach (var childInfo in directoryChildInfos)
                {
                    GetChildDirectory(directoryInfos, childInfo);
                }
            }
        }
    }
}