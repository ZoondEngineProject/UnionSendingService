using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UnionSendingService.Library.ZELab.Dispatcher;

namespace UnionSendingService.Library.ZELab.Net
{
    class ReceivingRef
    {
        protected int Port = 8789;
        protected UdpClient Udp;
        protected IPEndPoint EndPoint;

        protected Form1 Form;

        protected Byte[] StreamBytes = new Byte[8192];
        protected MemoryStream MStream;
        protected FileStream SavingFileStream = null;

        public string Status;

        private static SerializeFileInfo SerializeInfo;

        public ReceivingRef()
        {
            this.MStream = new MemoryStream();
            this.Form = new Form1();
        }

        public void Receive()
        {
            try
            {
                this.Status = "RECEIVING";

                this.Udp = new UdpClient(this.Port);
                this.Udp.EnableBroadcast = true;

                this.EndPoint = null;

                this.RecFInfo();
                this.RecFile();
            }
            catch (Exception ex)
            {
                this.Status = "ABORT";

                if (ex is ThreadAbortException)
                {
                    return;
                }
                else
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                if (this.SavingFileStream != null)
                {
                    this.SavingFileStream.Close();
                }

                this.Udp.Close();
            }
        }

        private void RecFInfo()
        {
            this.StreamBytes = this.Udp.Receive(ref this.EndPoint);

            string RecString = Encoding.Default.GetString(this.StreamBytes);
            string[] PartsRecString = RecString.Split('|');

            SerializeInfo = new SerializeFileInfo();
            SerializeInfo.FileName = PartsRecString[0];
            SerializeInfo.FileSize = PartsRecString[1];
        }

        private void RecFile()
        {
            //Kostil
            if (!ApplicationServiceProvider.Creator.Boot("C:\\USS\\Downloads\\"))
            {
                ApplicationServiceProvider.Creator.Create("C:\\USS\\Downloads\\");
            }

            ApplicationServiceProvider.Folders.Boot(1, SerializeInfo.FileName, "C:\\USS\\Downloads\\");

            this.SavingFileStream = ApplicationServiceProvider.Folders.GetFileStream();

            MessageBox.Show("Получен файл: " + SerializeInfo.FileName + "\nРазмер: " + SerializeInfo.FileSize, "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //----END KOSTIL

            int count, iterator;

            count = int.Parse(SerializeInfo.FileSize);
            iterator = 0;

            /*
            for (; iterator < count; iterator += 8192)//Цикл пока не дойдём до конца файла
            {

                this.StreamBytes = this.Udp.Receive(ref this.EndPoint);
                this.SavingFileStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
            }
            */

            while(iterator < count)
            {
                this.StreamBytes = this.Udp.Receive(ref this.EndPoint);
                this.SavingFileStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);
                iterator += 8192;
            }

            MessageBox.Show("Файл: "
                + ApplicationServiceProvider.Folders.GetFileName()
                + " получен "
                , "Файл получен", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            this.SavingFileStream = ApplicationServiceProvider.Folders.GetFileStream();

            this.SavingFileStream.Write(this.StreamBytes, 0, this.StreamBytes.Length);

            this.Status = "OK";
            */

            /*
            MessageBox.Show("Файл: "
                + ApplicationServiceProvider.Folders.GetFileName()
                + " получен "
                , "Файл получен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
        }

        public void Abort()
        {
            if(this.SavingFileStream is FileStream)
            {
                this.SavingFileStream.Close();
            }
            this.Udp.Close();
        }
    }
}
