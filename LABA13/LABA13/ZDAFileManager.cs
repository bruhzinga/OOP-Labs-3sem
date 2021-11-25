using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LABA13
{
    internal class ZDAFileManager
    {
        public event Action<MethodBase, string> Update;

        /*Прочитать список файлов и папок заданного диска.Создать
        директорий XXXInspect, создать текстовый файл
        xxxdirinfo.txt и сохранить туда информацию. Создать
        копию файла и переименовать его. Удалить
        первоначальный файл*/

        public void Task1(string diskName)
        {
            string path = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAdirinfo.txt";
            string DestFileName = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAdirinfo2.txt";
            const string Path1 = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect";
            var Disk = new DirectoryInfo(diskName);
            if (!Disk.Exists) throw new Exception("disk does not exist");
            var foldersfiles = Disk.GetDirectories().Select(x => x.Name).Concat(Disk.GetFiles().Select(x => x.Name));

            Directory.CreateDirectory(Path1);
            using (File.Create(path)) { };

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foldersfiles.ToList().ForEach(x => sw.WriteLine(x));
            }
            File.Copy(path, DestFileName, true);
            File.Delete(path);
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        /*Создать еще один директорий XXXFiles. Скопировать в
        него все файлы с заданным расширением из заданного
        пользователем директория. Переместить XXXFiles в
        XXXInspect.*/

        public void Task2(string directory, string extension)
        {
            const string path = @"E:\source\bruhzinga\OOP\LABA13\ZDAfiles\";
            Directory.CreateDirectory(path);
            var specifiedDirectory = new DirectoryInfo(directory);
            if (!specifiedDirectory.Exists) throw new Exception("directory Does exist");
            var files = specifiedDirectory.GetFiles().Where(x => x.Extension == extension);
            foreach (var file in files)
            {
                var destFile = Path.Combine(path, file.Name);
                File.Copy(file.FullName, destFile, true);
            }

            const string Path1 = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAFiles";
            if (Directory.Exists(Path1)) Directory.Delete(Path1, true);
            const string SourceDirName = @"E:\source\bruhzinga\OOP\LABA13\ZDAfiles";
            const string DestDirName = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAFiles";
            Directory.Move(SourceDirName, DestDirName);
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }

        /*Сделайте архив из файлов директория XXXFiles.
        Разархивируйте его в другой директорий.*/

        public void Task3()
        {
            const string SourceDirectoryName = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAFiles";
            const string Path1 = @"E:\source\bruhzinga\OOP\LABA13\ZDAInspect\ZDAFiles.zip";
            const string DestinationDirectoryName = @"E:\source\bruhzinga\OOP\LABA13\uzipped";
            if (File.Exists(Path1)) File.Delete(Path1);

            ZipFile.CreateFromDirectory(SourceDirectoryName, Path1);
            if (Directory.Exists(DestinationDirectoryName)) Directory.Delete(DestinationDirectoryName, true);
            ZipFile.ExtractToDirectory(Path1, DestinationDirectoryName);
            Update?.Invoke(MethodBase.GetCurrentMethod(), null);
        }
    }
}