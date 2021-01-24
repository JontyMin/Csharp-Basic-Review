using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace MyIOSerialize.IO
{
    public class MyIO
    {

        /// <summary>
        /// 配置绝对路径
        /// </summary>
        private static string LogPath = ConfigurationManager.AppSettings["LogPath"];
        private static string MovePath = ConfigurationManager.AppSettings["MovePath"];


        // 获取相对路径
        private static string LogPath2 = AppDomain.CurrentDomain.BaseDirectory;


        public static async void Show()
        {
            // 检查路径是否存在
            if (Directory.Exists(LogPath))
            {
                
            }


            DirectoryInfo directory= new DirectoryInfo(LogPath); // 文件夹信息  如果不存在不报错 注意exists属性验证
            Console.WriteLine($"{directory.FullName}-{directory.CreationTime}-{directory.LastWriteTime}");

            if (!File.Exists(Path.Combine(LogPath,"info.txt")))
            {
                
            }

            FileInfo file = new FileInfo(Path.Combine(LogPath,"info.txt"));
            Console.WriteLine($"{file.Name}-{file.FullName}-{file.CreationTime}-{file.LastWriteTime}");


            // 写入流
            {
                // Directory
                if (!Directory.Exists(LogPath))
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(LogPath);//不存在则创建
                    DirectoryInfo directoryMove = Directory.CreateDirectory(MovePath);//不存在则创建
                    Directory.Move(LogPath, MovePath);// 移动 源文件夹消失
                    Directory.Delete(LogPath);
                }

                string fileName = Path.Combine(LogPath, "info.txt");
                string fileNameCopy = Path.Combine(LogPath, "logCopy.txt");
                string fileNameMove = Path.Combine(LogPath, "logCopy.txt");
                bool isExists = File.Exists(fileName);
                if (isExists)
                {
                    // 先创建文件夹，再创建文件
                    //Directory.CreateDirectory(LogPath);

                    // 打开文件流
                   /* using (FileStream fileStream = File.Create(fileName)) 
                    {
                        // 通过字节流写入文件
                        var name = Guid.NewGuid().ToString();
                        byte[] bytes = Encoding.Default.GetBytes(name);
                        await fileStream.WriteAsync(bytes, 0, bytes.Length);
                        await fileStream.FlushAsync();
                    }
                   */

                    using (FileStream fileStream = File.OpenWrite(fileName))
                    {
                        StreamWriter sw = new StreamWriter(fileStream);
                        await sw.WriteLineAsync(Guid.NewGuid().ToString());
                        await sw.FlushAsync();
                    }

                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        string msg = "今天是2021/01/24 广州";
                        await sw.WriteLineAsync(msg);
                        await sw.FlushAsync();
                    }

                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        string name = "jonty";
                        byte[] bytes = Encoding.Default.GetBytes(name);
                        await sw.BaseStream.WriteAsync(bytes, 0, bytes.Length);
                        await sw.FlushAsync();
                    }

                }
                // 读取流
                {
                    foreach (var result in File.ReadAllLines(fileName))
                    {
                        Console.WriteLine(result);
                    }

                    string sResult = File.ReadAllText(fileName);
                    Byte[] byteContent = File.ReadAllBytes(fileName);
                    string sResultByte = Encoding.UTF8.GetString(byteContent);
                    Console.WriteLine(sResultByte);
                }

                using (FileStream stream =File.OpenRead(fileName))//分批读取
                {
                    int length = 5;
                    int result = 0;
                    do
                    {
                        byte[]bytes=new byte[length];
                        result = stream.Read(bytes, 0, 5);
                        for (int i = 0; i < result; i++)
                        {
                            Console.WriteLine(bytes[i].ToString());
                        }
                    } while (length==result);
                }

                File.Copy(fileName,fileNameCopy);
                File.Move(fileName,fileNameMove);
                File.Delete(fileNameCopy);
                File.Delete(fileName); // 尽量不要delete
            }


            
        }
    }
}