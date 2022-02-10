using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneyRecipes;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace JourneyRecipes.Items.Accessories
{
    [AutoloadEquip]
    public class TitanGlove : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.TitanGlove || item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.FireGauntlet))
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerTitanGlove = true;
            }
        }
    }
}