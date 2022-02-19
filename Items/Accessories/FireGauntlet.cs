using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.IO;
using Terraria.IO;

namespace JourneyRecipes.Items.Accessories
{
    public class FireGauntlet : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FireGauntlet)
            {
                player.meleeDamage += .02f;
                player.meleeSpeed += .02f;
            }
        }
    }
}