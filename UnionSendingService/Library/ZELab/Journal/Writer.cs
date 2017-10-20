namespace UnionSendingService.Library.ZELab.Journal
{
    class Writer
    {
        private string Text;
        private int How;
        private Form1 Form;

        public Writer(int how, string text)
        {
            this.Text = text;
            this.How = how;
            this.Form = new Form1();
        }

        public void Error()
        {
            this.Form.JournalingInformation(this.How, this.Text, 0);
        }

        public void Warning()
        {
            this.Form.JournalingInformation(this.How, this.Text, 1);
        }

        public void Information()
        {
            this.Form.JournalingInformation(this.How, this.Text, 2);
        }

        public void Success()
        {
            this.Form.JournalingInformation(this.How, this.Text, 3);
        }
    }
}
