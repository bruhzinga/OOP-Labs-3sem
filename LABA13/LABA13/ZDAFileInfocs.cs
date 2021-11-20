using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA13
{
    internal class ZDAFileInfo
    {
        public event Action<MethodBase, string> Update;

        public FileInfo info;

        public ZDAFileInfo(FileInfo currentfile)
        {
            info = currentfile;
        }

        public void ShowFullPath()
        {
            Console.WriteLine(info.FullName);
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        public void ShowSizeNameExtension()
        {
            Console.WriteLine($"Size of file: {info.Length} Extension: {info.Extension} Name: {info.Name}");
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        public void ShowDates()
        {
            Console.WriteLine($"Date of creation: {info.CreationTime} Date of last change {info.LastWriteTime}");
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }
    }
}