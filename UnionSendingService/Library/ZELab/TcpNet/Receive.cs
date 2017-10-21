using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using UnionSendingService.Library.ZELab.Dispatcher;

namespace UnionSendingService.Library.ZELab.TcpNet
{
    class Receive
    {
        private FileStream FStream;
        private SerializeFileInfo FileInfo;
        private Socket ReceivingSocket;
        private TcpListener Listener;
        private int Port = 8789;
        private Byte[] InputBytes;

        public void Boot()
        {
            Listener = new TcpListener(IPAddress.Any, Port);
            Listener.Start();

            try
            {
                ReceivingSocket = Listener.AcceptSocket();

                if(ReceivingSocket.Connected)
                {
                    ReceiveFileInformation();

                    ReceiveFile();
                }
                else
                {
                    MessageBox.Show("Client has disconnected");
                }
            }
            catch (Exception ex)
            {
                Abort();
                MessageBox.Show(
                    "Не удалось загрузить файл\n"
                    + "Код ошибки: 00002S\n"
                    + "Точка входа: TcpNet.Receiver\n"
                    + ex.Message + "\nStackTrace:\n"
                    + ex.StackTrace
                    , "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveFileInformation()
        {
            ReceivingSocket.Receive(InputBytes);

            string RecString = Encoding.Default.GetString(InputBytes);
            string[] PartsRecString = RecString.Split('|');

            FileInfo = new SerializeFileInfo();
            FileInfo.FileName = PartsRecString[0];
            FileInfo.FileSize = PartsRecString[1];
        }

        private void ReceiveFile()
        {
            if (!ApplicationServiceProvider.Creator.Boot("C:\\USS\\Downloads\\"))
            {
                ApplicationServiceProvider.Creator.Create("C:\\USS\\Downloads\\");
            }

            ApplicationServiceProvider.Folders.Boot(1, FileInfo.FileName, "C:\\USS\\Downloads\\");

            this.FStream = ApplicationServiceProvider.Folders.GetFileStream();

            MessageBox.Show("Загружается файл: " + FileInfo.FileName + "\nРазмер: " + FileInfo.FileSize + " Байт", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReceivingSocket.Receive(InputBytes);
            this.FStream.Write(this.InputBytes, 0, this.InputBytes.Length);

            MessageBox.Show("Файл успешно загружен\nСохранен в: C:\\USS\\Downloads\\" + FileInfo.FileName, "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Abort()
        {
            ReceivingSocket.Close();
            Listener.Stop();
        }
    }
}
