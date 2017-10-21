using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using UnionSendingService.Library.ZELab.Dispatcher;

namespace UnionSendingService.Library.ZELab.Net
{
    class SendingRef
    {
        private IPAddress IPAddr;
        private int Port = 8789;
        private UdpClient Udp;

        private Byte[] StreamBytes;
        private FileStream FStream;

        //public string Status;

        public void Send(string ip)
        {
            try
            {
                this.FStream = ApplicationServiceProvider.Folders.GetFileStream();

                this.IPAddr = IPAddress.Parse(ip);
                this.Udp = new UdpClient();
                this.Udp.Connect(this.IPAddr, this.Port);
                this.Udp.EnableBroadcast = true;

                this.SendFileInfo();

                this.SendFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (this.FStream is FileStream)
                {
                    this.FStream.Close();
                }

                this.Udp.Close();
            }
        }

        private void SendFileInfo()
        {
            string fd;
            fd = ApplicationServiceProvider.Folders.GetFileName() + "|" + this.FStream.Length;

            this.StreamBytes = Encoding.Default.GetBytes(fd);

            // Отправляем информацию о файле
            this.Udp.Send(this.StreamBytes, this.StreamBytes.Length);
        }

        private void SendFile()
        {
            try
            {
                this.FStream.Position = 0;
                this.StreamBytes = new Byte[8192];

                int count;
                long size = this.FStream.Length;

                while((count = this.FStream.Read(this.StreamBytes, 0, 8192)) > 0)
                {
                    this.Udp.Send(this.StreamBytes, this.StreamBytes.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + this.FStream.ToString(), "Внутренняя ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Файл: "
                + ApplicationServiceProvider.Folders.GetFileName()
                + " размером "
                + ApplicationServiceProvider.Folders.GetFileSize()
                + " успешно отправлен."
                , "Файл отправлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Закрываем соединение и очищаем поток
                if (this.FStream is FileStream)
                {
                    this.FStream.Close();
                }
                this.Udp.Close();
            }
        }
    }
}
