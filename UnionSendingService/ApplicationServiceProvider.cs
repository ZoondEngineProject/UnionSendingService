namespace UnionSendingService
{
    class ApplicationServiceProvider
    {
        /// <summary>
        /// Предоставляет объект Journal для работы с журналом.
        /// </summary>
        public static Library.ZELab.Journal.Manager Journal = new Library.ZELab.Journal.Manager();

        /// <summary>
        /// Предоставляет объект Folders для работы с файлами.
        /// </summary>
        public static Library.ZELab.Dispatcher.Folders Folders = new Library.ZELab.Dispatcher.Folders();

        /// <summary>
        /// Предоставляет объект Antivirus для защиты данных.
        /// </summary>
        public static Library.ZELab.Antivirus.Manager Antivirus = new Library.ZELab.Antivirus.Manager();

        /// <summary>
        /// Предоставляет объект Net.ReceivingRef для работы с сетью.
        /// </summary>
        //public static Library.ZELab.Net.ReceivingRef Receive = new Library.ZELab.Net.ReceivingRef();
        public static Library.ZELab.TcpNet.Receive Receive = new Library.ZELab.TcpNet.Receive();

        /// <summary>
        /// Предоставляет объект Net.SendingRef для работы с сетью.
        /// </summary>
        //public static Library.ZELab.Net.SendingRef Sending = new Library.ZELab.Net.SendingRef();
        public static Library.ZELab.TcpNet.Send Sending = new Library.ZELab.TcpNet.Send();

        /// <summary>
        /// 
        /// </summary>
        public static Library.ZELab.Dispatcher.Creator Creator = new Library.ZELab.Dispatcher.Creator();
    }
}
