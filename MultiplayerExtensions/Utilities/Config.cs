using Newtonsoft.Json;

namespace MultiplayerExtensions
{
    public class PluginConfig
    {
        public virtual bool SingleplayerHUD { get; set; } = false;
        public virtual bool Hologram { get; set; } = true;
        public virtual bool LagReducer { get; set; } = false;
        public virtual bool MissLighting { get; set; } = true;
        public virtual string Color { get; set; } = "#08C0FF";
        public virtual int MaxPlayers { get; set; } = 10;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DebugConfig? DebugConfig { get; set; }
    }

    public class DebugConfig
    {
        public virtual bool FailDownloads { get; set; } = false;
        public virtual int MinDownloadTime { get; set; } = 0;
    }
}
