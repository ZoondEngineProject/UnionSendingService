using System.Threading;
using System;
using System.IO;
using System.Xml.Serialization;

namespace UnionSendingService.Library.ZELab.Network
{
    class Send : Manager
    {
        private MemoryStream mStream = new MemoryStream();
        private FileStream fStream;
        private Byte[] streamBytes;

        public Send()
        {
            this.mStream = new MemoryStream();
        }

        public void Start()
        {
            mStream = new MemoryStream();
            
            fStream = ApplicationServiceProvider.Folders.GetFileStream();

            this.SendFileInfo();

            Thread.Sleep(2000);

            this.SendFile();
        }

        private void SendFileInfo()
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Dispatcher.SerializeFileInfo));

            Serializer.Serialize(this.mStream, new Dispatcher.SerializeFileInfo());

            this.mStream.Position = 0;
            this.streamBytes = new Byte[this.mStream.Length];

            this.mStream.Read(this.streamBytes, 0, Convert.ToInt32(this.mStream.Length));

            Console.WriteLine("Отправка деталей файла...");

            // Отправляем информацию о файле
            base.Udp.Send(this.streamBytes, this.streamBytes.Length, base.EndPoint);
            this.mStream.Close();

        }

        private void SendFile()
        {
            this.streamBytes = new Byte[this.fStream.Length];
            this.fStream.Read(this.streamBytes, 0, this.streamBytes.Length);

            //Сводка...

            try
            {
                // Отправляем файл
                base.Udp.Send(this.streamBytes, this.streamBytes.Length, base.EndPoint);
            }
            catch (Exception ex)
            {
                //Ошибка в журнал
            }
            finally
            {
                // Закрываем соединение и очищаем поток
                this.fStream.Close();
                base.Udp.Close();
            }

            //Запись в журнал об отправке

        }
    }
}
