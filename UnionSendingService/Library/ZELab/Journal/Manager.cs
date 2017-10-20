namespace UnionSendingService.Library.ZELab.Journal
{
    class Manager
    {
        private Form1 Form;

        private int Journalable, JournalableType;
        private string JournalableText;

        public Manager()
        {
            this.Form = new Form1();
        }

        public Manager Send()
        {
            this.Journalable = 0;

            return this;
        }

        public Manager Receive()
        {
            this.Journalable = 1;

            return this;
        }

        public Manager Write(string text)
        {
            this.JournalableText = text;

            return this;
        }

        public void Error()
        {
            this.JournalableType = 0;

            this.Journaling();
        }

        public void Warning()
        {
            this.JournalableType = 1;

            this.Journaling();
        }

        public void Information()
        {
            this.JournalableType = 2;

            this.Journaling();
        }

        public void Success()
        {
            this.JournalableType = 3;

            this.Journaling();
        }

        private void Journaling()
        {
            this.Form.JournalingInformation(this.Journalable, this.JournalableText, this.JournalableType);
        }
    }
}
