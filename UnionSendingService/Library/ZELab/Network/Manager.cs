using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace UnionSendingService.Library.ZELab.Network
{
    class Manager
    {
        protected IPAddress IPAddr;
        protected int Port = 8789;
        protected UdpClient Udp;
        protected IPEndPoint EndPoint;

        private Send Sender;
        private Receive Receiver;

        protected Form1 Form;

        public Manager()
        {
            Form = new Form1();
        }

        public void Boot(int type, string ipAddr = null)
        {
            if(type.Equals(0xf00000))
            {
                this.CauseToSend(ipAddr);
            }
            else if(type.Equals(0xf00001))
            {
                this.CauseToReceive();
            }
            else
            {
                //ApplicationServiceProvider.Journal.Send.Write().Error("Недопустимый тип подключения");
                //ApplicationServiceProvider.Journal.Receive.Write().Error("Недопустимый тип подключения");

                return;
            }
        }

        private void CauseToSend(string ipAddr)
        {
            this.Sender = new Send();

            try
            {
                this.IPAddr = IPAddress.Parse(ipAddr);
                this.EndPoint = new IPEndPoint(this.IPAddr, this.Port);
                this.Udp = new UdpClient(this.EndPoint);

                this.Form.AcceptConnectionStatus(true);

                this.Sender.Start();
            }
            catch(Exception ex)
            {

            }
        }

        private void CauseToReceive()
        {
            this.Receiver = new Receive();

            try
            {
                this.Udp = new UdpClient(this.Port);
                this.EndPoint = null;

                this.Receiver.Start();
            }
            catch(Exception ex)
            {

            }
        }

        public void Abort()
        {
            this.Udp.Close();
        }
    }
}
