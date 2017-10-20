namespace UnionSendingService.Library.ZELab.Journal
{
    class Send
    {
        //private int Flag;

        public Writer Write(string text)
        {
            //this.Flag = 0xf00010;
            Writer wr = new Writer(0, text);

            return wr;
        }
    }
}
