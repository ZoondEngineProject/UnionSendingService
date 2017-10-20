using System;
using System.IO;

namespace UnionSendingService.Library.ZELab.Dispatcher
{
    class Folders
    {
        private string FileName, FilePath;
        private int FileSize;
        private FileStream FSObject;

        public Folders()
        {
            //Clearing data
            this.FileName = null;
            this.FilePath = null;
            this.FSObject = null;
            this.FileSize = 0;
        }

        public void Boot(int type, string fn, string fp)
        {
            this.FileName = fn;
            this.FilePath = fp;

            if (type == 0)
            {
                this.FSObject = new FileStream(this.FilePath, FileMode.Open);
            }
            else if(type == 1)
            {
                this.FSObject = new FileStream(fp + "temp.USS." + fn, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            }
            else
            {
                //Error
                return;
            }

            this.FileSize = Convert.ToInt32((int)this.FSObject.Length) / 1024 / 1024; //Convert To MB
        }

        public string GetFileName()
        {
            return this.FileName;
        }

        public string GetFilePath()
        {
            return this.FilePath;
        }

        public string GetFileSize()
        {
            return this.FileSize + " МБ";
        }

        public FileStream GetFileStream()
        {
            return this.FSObject;
        }
    }
}
