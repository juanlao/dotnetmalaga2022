namespace Features.Offline
{
    public interface IOfflineModeSettingsProvider
    {
        bool IsActive { get; set; }
    }
}