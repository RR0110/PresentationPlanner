using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.PowerPoint;
using System.Threading;

namespace PresentationPlanner.BL
{
    public class FileManager
    {
        private FileInfo[] GetListOfPresentationFiles(String dirPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
            FileInfo[] presentationFiles = directoryInfo.GetFiles();

            //Фильтрация файлов презентации из общей кучи файлов
            List<FileInfo> filteredPresentationFiles = new List<FileInfo>();
            string [] filterExtensions = {".pptx", ".ppt", ".pptm", ".ppsx"};
            foreach (FileInfo file in presentationFiles)
            {
                foreach(String filterExtension in filterExtensions)
                {
                    if (filterExtension == file.Extension) filteredPresentationFiles.Add(file);
                }
            }

            return filteredPresentationFiles.ToArray();
        }

        private FileInfo GetLastChangeFile(FileInfo[] files)
        {
            DateTime lastChangeTime = files[0].LastWriteTime;
            FileInfo lastChangeFile = files[0];
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastChangeTime)
                {
                    lastChangeTime = file.LastWriteTime;
                    lastChangeFile = file;
                }
            }
            return lastChangeFile;
        }

        private void OpenFile(FileInfo file, String powerPointPath)
        {
            ProcessStartInfo info = new ProcessStartInfo(powerPointPath);
            Process presentation;
            info.Arguments = " /S " + "\"" + file.FullName + "\"";
            presentation = Process.Start(info);
            Thread.Sleep(3000);
            if (!presentation.HasExited) { presentation.Kill(); }
            //presentation.CloseMainWindow();
            //presentation.Close();
        }

        public void Start(String dirPath, String powerPointPath)
        {
            FileInfo[] files = GetListOfPresentationFiles(dirPath);
            FileInfo lastChangeFile = GetLastChangeFile(files);
            OpenFile(lastChangeFile, powerPointPath);
        }
    }
}
