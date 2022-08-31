using Synapse.Api.Plugin;
using Synapse.Translation;

namespace CustomInventories
{
    [PluginInformation(
        Author = "LoliEnjoyeer",
        Description = "",
        LoadPriority = 0,
        Name = "CustomInventories",
        SynapseMajor = 2,
        SynapseMinor = 10,
        SynapsePatch = 0,
        Version = "1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Config(section = "CustomInventories")]
        public static PluginConfig Config;

        [SynapseTranslation]
        public new static SynapseTranslation<PluginTranslation> Translation { get; set; }

        public override void Load()
        {
            new EventHandlers();
        }
    }
}