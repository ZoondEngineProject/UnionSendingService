using System.Threading;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;
using System.Diagnostics;


namespace UnionSendingService.Library.ZELab.Network
{
    class Receive : Manager
    {
        private Byte[] StreamBytes;
        private MemoryStream MStream;
        private Dispatcher.SerializeFileInfo SerializeInfo;
        private FileStream SavingFileStream;

        public Receive()
        {
            this.MStream = new MemoryStream();
        }

        public void Start()
        {
            this.ReceiveFileInfo();

            this.ReceiveFile();
        }

        private void ReceiveFileInfo()
        {
            try
            {
                this.StreamBytes = base.Udp.Receive(ref base.EndPoint);

                XmlSerializer Serializer = new XmlSerializer(typeof(Dispatcher.SerializeFileInfo));

                this.MStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
                this.MStream.Position = 0;

                this.SerializeInfo = (Dispatcher.SerializeFileInfo)Serializer.Deserialize(this.MStream);
            }
            catch(Exception ex)
            {

            }
        }

        private void ReceiveFile()
        {
            try
            {
                this.StreamBytes = base.Udp.Receive(ref base.EndPoint);
                ApplicationServiceProvider.Folders.Boot(1, Dispatcher.SerializeFileInfo.FileName, "C:\\USS\\Downloads\\");
                this.SavingFileStream = ApplicationServiceProvider.Folders.GetFileStream();

                this.SavingFileStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                this.SavingFileStream.Close();
                base.Udp.Close();
            }
        }
    }
}
