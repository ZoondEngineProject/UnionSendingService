using System.Threading;
using System;
using System.IO;
using System.Xml.Serialization;

namespace UnionSendingService.Library.ZELab.Network
{
    class Send : Manager
    {
        private MemoryStream MStream;
        private FileStream FStream;
        private Byte[] StreamBytes;

        public void Start()
        {
            this.MStream = new MemoryStream();
            this.FStream = ApplicationServiceProvider.Folders.GetFileStream();

            this.SendFileInfo();

            Thread.Sleep(2000);

            this.SendFile();
        }

        private void SendFileInfo()
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Dispatcher.SerializeFileInfo));

            Serializer.Serialize(this.MStream, new Dispatcher.SerializeFileInfo());

            this.MStream.Position = 0;
            this.StreamBytes = new Byte[this.MStream.Length];

            this.MStream.Read(this.StreamBytes, 0, Convert.ToInt32(this.MStream.Length));

            Console.WriteLine("Отправка деталей файла...");

            // Отправляем информацию о файле
            base.Udp.Send(this.StreamBytes, this.StreamBytes.Length, base.EndPoint);
            this.MStream.Close();

        }

        private void SendFile()
        {
            this.StreamBytes = new Byte[this.FStream.Length];
            this.FStream.Read(this.StreamBytes, 0, this.StreamBytes.Length);

            //Сводка...

            try
            {
                // Отправляем файл
                base.Udp.Send(this.StreamBytes, this.StreamBytes.Length, base.EndPoint);
            }
            catch (Exception ex)
            {
                //Ошибка в журнал
            }
            finally
            {
                // Закрываем соединение и очищаем поток
                this.FStream.Close();
                base.Udp.Close();
            }

            //Запись в журнал об отправке

        }
    }
}
