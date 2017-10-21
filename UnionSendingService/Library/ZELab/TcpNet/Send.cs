using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace UnionSendingService.Library.ZELab.TcpNet
{
    class Send
    {
        private IPAddress IPAddr;
        private int Port = 8789;
        private TcpClient Tcp;
        private Socket RemoteClient;

        private Byte[] StreamBytes;
        private FileStream FStream;

        private string Status;

        public void Boot(string ip)
        {
            try
            {
                FStream = ApplicationServiceProvider.Folders.GetFileStream();


                IPAddr = IPAddress.Parse(ip);
                Tcp.Connect(IPAddr, Port);

                int i = 0;
                while(!Tcp.Connected)
                {
                    Thread.Sleep(1000);

                    i++;

                    if(i == 10)
                    {
                        Status = "TIMEDOUT";
                        break;
                    }
                }

                if(Tcp.Connected)
                {
                    RemoteClient = Tcp.Client;
                }

                SendFileInfo();

                Thread.Sleep(1);

                SendFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                switch(Status)
                {
                    case "OK":
                        {
                            if (FStream is FileStream)
                            {
                                FStream.Close();
                            }

                            Tcp.Close();
                            RemoteClient.Close();

                            MessageBox.Show("Файл успешно загружен", "Загрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    case "TIMEDOUT":
                        {
                            if (FStream is FileStream)
                            {
                                FStream.Close();
                            }

                            Tcp.Close();

                            MessageBox.Show("Код ошибки: 00001S\nТочка входа: TcpNet.Sender\nОписание ошибки: Превышен лимит ожидания для подключения", "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
            }
        }

        private void SendFileInfo()
        {
            string fd;
            fd = ApplicationServiceProvider.Folders.GetFileName() + "|" + this.FStream.Length;

            this.StreamBytes = Encoding.Default.GetBytes(fd);

            // Отправляем информацию о файле
            RemoteClient.Send(this.StreamBytes);
        }

        private void SendFile()
        {
            /*
            FStream.Position = 0;

            int count;
            long size = this.FStream.Length;

            while ((count = this.FStream.Read(this.StreamBytes, 0, 8192)) > 0)
            {
                this.Udp.Send(this.StreamBytes, this.StreamBytes.Length);
            }
            */

            RemoteClient.SendFile(ApplicationServiceProvider.Folders.GetFilePath());
            Status = "OK";
        }
    }
}
