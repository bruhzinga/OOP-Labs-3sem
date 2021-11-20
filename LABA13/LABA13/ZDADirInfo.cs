using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA13
{
    internal class ZDADirInfo
    {
        public event Action<MethodBase, string> Update;

        public DirectoryInfo info;

        public ZDADirInfo(string path)
        {
            info = new DirectoryInfo(path);
        }

        public void CountFiles()
        {
            Console.WriteLine($"Files in directory {info.GetFiles().Length}");
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        public void CreationDate()
        {
            Console.WriteLine($"Date of creation: {info.CreationTime}");
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        public void CountSubDirs()
        {
            Console.WriteLine($"Subdirectories : {info.GetDirectories().Length}");
        }
    }
}