namespace UnionSendingService.Library.ZELab.Journal
{
    class Receive
    {
        //private int Flag;

        public Writer Write(string text)
        {
            //this.Flag = 0xf00010;

            return new Writer(1, text);
        }
    }
}
