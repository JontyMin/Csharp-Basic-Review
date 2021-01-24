using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIOSerialize.IO;

namespace MyIOSerialize
{
    class Program
    {
        static void Main(string[] args)
        {

            MyIO.Show();

            Console.WriteLine(Constant.LogPath);


            Console.WriteLine("============================domain=================================");
            // 当前应用程序路径
            string domain = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(domain);


            Console.WriteLine("============================driveInfos=================================");

            // 检查驱动器信息
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (var info in driveInfos)
            {

                if (info.IsReady)
                {
                    Console.WriteLine($"Driver Name:{info.Name}"); // 名称 C / D
                    Console.WriteLine($"Format:{info.DriveFormat}"); // 格式 NTFS
                    Console.WriteLine($"Type:{info.DriveType}"); // 类型 Fixed
                    Console.WriteLine($"Root directory:{info.RootDirectory}"); // 根文件夹
                    Console.WriteLine($"Volume label:{info.VolumeLabel}"); // 名称 
                    Console.WriteLine($"Free Space:{info.TotalFreeSpace}"); // 可用空间
                    Console.WriteLine($"Available Free Space:{info.AvailableFreeSpace}"); // 实际可用
                    Console.WriteLine($"TotalSize:{info.TotalSize}"); // 总空间
                    Console.WriteLine();
                }
            }
        }
    }
}
