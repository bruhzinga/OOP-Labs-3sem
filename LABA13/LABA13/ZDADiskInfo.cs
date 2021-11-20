using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA13
{
    internal class ZDADiskInfo
    {
        public event Action<MethodBase, string> Update;

        public void ShowFreeSpaceOnDrive(string driveName)
        {
            var drive = new DriveInfo(driveName);
            Console.WriteLine($"Free space on drive :{driveName} is {(float)(drive.AvailableFreeSpace / (float)1048576) } megabatyes");

            Update?.Invoke(MethodBase.GetCurrentMethod(), $"{driveName}");
        }

        public void ShowFileSystemnfo()
        {
            DriveInfo.GetDrives().ToList().ForEach(x => Console.WriteLine($"{x.Name} drive has {x.DriveFormat} format"));

            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        public void ShowInfoForAll()
        {
            DriveInfo.GetDrives().ToList()
                .ForEach((x) => Console.WriteLine($"{x.Name} volume: {(float)((x.TotalSize) / (float)1048576)}  free space: {(float)(x.AvailableFreeSpace / (float)1048576) } Label: {x.VolumeLabel} "));
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }
    }
}
}