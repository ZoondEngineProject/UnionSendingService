using System.IO;

namespace UnionSendingService.Library.ZELab.Dispatcher
{
    class Creator
    {
        public bool Boot(string path)
        {
            if(Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Create(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
