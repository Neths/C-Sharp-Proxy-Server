namespace proxyServer
{
    interface IService
    {
        bool Started { get; set; }
        bool SelfInteractive { get; set; }
        string PRestore { get; set; }
        void WarningMessage();
    }
}