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
        public Receive()
        {
            base.MStream = new MemoryStream();
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
                base.StreamBytes = base.Udp.Receive(ref base.EndPoint);

                XmlSerializer Serializer = new XmlSerializer(typeof(Dispatcher.SerializeFileInfo));

                base.MStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
                base.MStream.Position = 0;

                base.SerializeInfo = (Dispatcher.SerializeFileInfo)Serializer.Deserialize(base.MStream);
            }
            catch(Exception ex)
            {

            }
        }

        private void ReceiveFile()
        {
            try
            {
                base.StreamBytes = base.Udp.Receive(ref base.EndPoint);
                ApplicationServiceProvider.Folders.Boot(1, Dispatcher.SerializeFileInfo.FileName, "C:\\USS\\Downloads\\");
                base.SavingFileStream = ApplicationServiceProvider.Folders.GetFileStream();

                base.SavingFileStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                base.SavingFileStream.Close();
                base.Udp.Close();
            }
        }
    }
}
