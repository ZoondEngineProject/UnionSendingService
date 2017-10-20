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
        /// Предоставляет объект Network для работы с сетью.
        /// </summary>
        public static Library.ZELab.Network.Manager Network = new Library.ZELab.Network.Manager();
    }
}
