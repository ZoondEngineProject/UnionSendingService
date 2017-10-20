namespace UnionSendingService.Library.ZELab.Journal
{
    class Manager
    {
        private Send Sender;
        private Receive Receiver;

        public Send Send()
        {
            this.Sender = new Send();

            return this.Sender;
        }

        public Receive Receive()
        {
            this.Receiver = new Receive();

            return this.Receiver;
        }
    }
}
