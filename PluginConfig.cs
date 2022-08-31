using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomInventories
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("Is plugin enabled?")]
        public bool isEnabled = true;

        [Description("Inventory Config")]
        public List<Inventory> Inventory { get; set; } = new List<Inventory>()
        {
            new Inventory()
        };
    }
}