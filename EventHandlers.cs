using MEC;
using Synapse;
using Synapse.Api;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Api.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomInventories
{
    public class EventHandlers
    {
        public EventHandlers()
        {
            if (PluginClass.Config.isEnabled)
                Server.Get.Events.Player.PlayerSetClassEvent += OnSetClass;
        }

        private void OnSetClass(PlayerSetClassEventArgs ev)
        {
            if (Round.Get.RoundIsActive)
            {
                Timing.CallDelayed(0.02f, () =>
                {
                    Player pl = ev.Player;
                    PlayerInventory inv = ev.Player.Inventory;
                    List<CustomInventories.Inventory> listOfInventories = PluginClass.Config.Inventory;

                    if (listOfInventories.Any(any => any.ClassID == pl.RoleID))
                    {
                        var inventory = listOfInventories.FirstOrDefault(fod => fod.ClassID == pl.RoleID);
                        if (inventory is null)
                            return;

                        inv.Clear();

                        foreach (var item in inventory.SlotList)
                        {
                            try
                            {
                                Logger.Get.Send(inv[item.Index].ID, ConsoleColor.Black);
                            }
                            catch
                            {
                                if (UnityEngine.Random.Range(0f, 100f) <= item.Chance)
                                    inv.AddItem(item.ItemID);
                            }
                            finally
                            {
                                if (UnityEngine.Random.Range(0f, 100f) <= item.Chance)
                                {
                                    inv[item.Index].Destroy();
                                    inv.AddItem(item.ItemID);
                                }
                            }
                        }
                    }
                });
            }
        }
    }
}